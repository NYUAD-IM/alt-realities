using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HolsterController : MonoBehaviour
{
    public XRRig rig;

    private void Update()
    {
        Vector3 offset = rig.cameraGameObject.transform.localPosition - new Vector3(0, rig.cameraYOffset / 2.0f, 0);
        transform.localPosition = offset;

        Vector3 rotation = transform.localEulerAngles;
        rotation.y = rig.cameraGameObject.transform.localEulerAngles.y;
        transform.localEulerAngles = rotation;
    }
}
