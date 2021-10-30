using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer : MonoBehaviour
{
    public string toScene = "XR";
    public bool changeLayer = true;
    public int toLayer = 0; //default layer

    string previousScene;
    int previousLayer = 0;

    public void Transfer()
    {
        if (gameObject.scene.name == toScene) return; //nothing to do here

        if (gameObject.transform.parent != null)
        {
            //have to move GO to root of scene first
            gameObject.transform.SetParent(null);
        }
        Scene newScene = SceneManager.GetSceneByName(toScene);
        if(newScene.IsValid())
        {
            previousScene = gameObject.scene.name;
            previousLayer = gameObject.layer;
            SceneManager.MoveGameObjectToScene(gameObject, newScene);
            if(changeLayer) gameObject.layer = toLayer;
        }
        else
        {
            Debug.LogWarning("tried to transfer object to invalid scene: " + toScene);
        }
    }

    public void Return()
    {
        if (previousScene == string.Empty)
        {
            //if we don't have a previous scene, we never transitioned
            return;
        }

        Scene prevScene = SceneManager.GetSceneByName(previousScene);
        if (!prevScene.IsValid())
        {
            //if the previous scene is gone, return it to the active scene
            previousScene = SceneManager.GetActiveScene().name;
            prevScene = SceneManager.GetSceneByName(previousScene);
        }

        if (changeLayer) gameObject.layer = previousLayer;

        if (gameObject.scene.name == previousScene) return; //XR Interaction may have already put it back

        SceneManager.MoveGameObjectToScene(gameObject, prevScene);
    }
}
