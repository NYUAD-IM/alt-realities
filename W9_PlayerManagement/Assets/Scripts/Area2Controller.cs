using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area2Controller : XRSceneController
{
    public override void Init()
    {
        PlayerManager.Instance.hasVistedArea2 = true;
    }
}
