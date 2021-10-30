using UnityEngine;

public class XRSceneController : MonoBehaviour
{
    public Transform xrRigOrigin;

    public virtual void Init() { }

    public virtual Transform GetXRRigOrigin()
    {
        return xrRigOrigin;
    }
}
