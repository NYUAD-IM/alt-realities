using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public static class SceneSelector 
{
    [MenuItem("Scenes/Lobby")]
    public static void LoadLobby()
    {
        Load("Lobby");
    }

    [MenuItem("Scenes/Green Place")]
    public static void LoadGreenPlace()
    {
        Load("GreenPlace");
    }

    [MenuItem("Scenes/Red Place")]
    public static void LoadRedPlace()
    {
        Load("RedPlace");
    }

    static void Load(string scene)
    {
        //don't lose changes!
        EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();

        var xr = EditorSceneManager.OpenScene("Assets/Scenes/XR.unity", OpenSceneMode.Single);
        var newScene = EditorSceneManager.OpenScene("Assets/Scenes/" + scene + ".unity", OpenSceneMode.Additive);
        XRSceneTransitionManager.PlaceXRRig(xr, newScene);
    }
}
