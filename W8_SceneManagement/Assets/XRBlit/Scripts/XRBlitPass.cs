using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

internal class XRBlitPass : ScriptableRenderPass
{
    ProfilingSampler sampler = new ProfilingSampler("XRBlit");
    Material material;

    public XRBlitPass(Material material)
    {
        this.material = material;
    }

    public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
    {
        var camera = renderingData.cameraData.camera;
        if (camera.cameraType != CameraType.Game)
            return;

        if (material == null)
            return;

        CommandBuffer cmd = CommandBufferPool.Get();
        using (new ProfilingScope(cmd, sampler))
        {
            cmd.SetRenderTarget(
                new RenderTargetIdentifier(renderingData.cameraData.renderer.cameraColorTarget, 0, CubemapFace.Unknown, -1),
                new RenderTargetIdentifier(renderingData.cameraData.renderer.cameraDepthTarget, 0, CubemapFace.Unknown, -1)
                );
            //The RenderingUtils.fullscreenMesh argument specifies that the mesh to draw is a quad.
            cmd.DrawMesh(RenderingUtils.fullscreenMesh, Matrix4x4.identity, material);
        }
        context.ExecuteCommandBuffer(cmd);
        cmd.Clear();

        CommandBufferPool.Release(cmd);
    }
}