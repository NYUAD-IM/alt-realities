using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    public bool hasVistedArea2 = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Created too many player managers. destroying this one");
            Destroy(this.gameObject);
            return;
        }
    }

    private void OnDestroy()
    {
        if(Instance == this) Instance = null;
    }
}
