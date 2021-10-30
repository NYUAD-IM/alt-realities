using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Area1Controller : XRSceneController
{
    public Transform xrRigOrigin2;

    public XRSocketInteractor keySlot;
    public XRBaseInteractable keyCard;

    public override void Init()
    {
        if(PlayerManager.Instance.hasVistedArea2)
        {
            keySlot.startingSelectedInteractable = keyCard;
        }
    }

    public override Transform GetXRRigOrigin()
    {
        return PlayerManager.Instance.hasVistedArea2 ? xrRigOrigin2 : xrRigOrigin;
    }
}
