using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using System.Linq;

public static class XRSceneSelector
{
    [MenuItem("XR Scenes/Lobby")]
    static void OpenLobby()
    {
        EditorXRSceneUtils.LoadXRScene("Lobby");
    }

}
