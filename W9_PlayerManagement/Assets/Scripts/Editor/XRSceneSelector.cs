using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using System.Linq;

public static class XRSceneSelector
{
    [MenuItem("XR Scenes/Area 1")]
    static void OpenArea1()
    {
        EditorXRSceneUtils.LoadXRScene("Area 1");
    }

    [MenuItem("XR Scenes/Area 2")]
    static void OpenArea2()
    {
        EditorXRSceneUtils.LoadXRScene("Area 2");
    }
}
