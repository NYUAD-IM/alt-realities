using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;

    public string initialScene;
    public bool isLoading { get; private set; } = false;

    Scene xrScene;
    Scene currentScene;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            //there can be only one!
            Destroy(this);
            return;
        }

        xrScene = SceneManager.GetActiveScene();
        SceneManager.sceneLoaded += OnNewSceneAdded;

        if(!Application.isEditor)
        {
            TransitionTo(initialScene);
        }
    }

    void OnNewSceneAdded(Scene newScene, LoadSceneMode mode)
    {
        if (newScene != xrScene)
        {
            SceneManager.SetActiveScene(newScene);
            currentScene = newScene;
            PlaceXRRig(xrScene, currentScene);
        }
    }

    public void TransitionTo(string scene)
    {
        if(!isLoading)
        {
            StartCoroutine(Load(scene));
        }
    }

    IEnumerator Load(string scene)
    {
        isLoading = true;
        yield return StartCoroutine(UnloadCurrent());

        yield return StartCoroutine(LoadNewScene(scene));
        isLoading = false;
    }

    IEnumerator UnloadCurrent()
    {
        AsyncOperation unload = SceneManager.UnloadSceneAsync(currentScene);
        while(!unload.isDone) 
            yield return null;
    }

    IEnumerator LoadNewScene(string name)
    {
        AsyncOperation load = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
        while (!load.isDone)
            yield return null;
    }

    public static void PlaceXRRig(Scene xrScene, Scene newScene)
    {
        GameObject[] xrObjects = xrScene.GetRootGameObjects();
        GameObject[] newSceneObjects = newScene.GetRootGameObjects();

        GameObject xrRig = xrObjects.First((obj) => { return obj.CompareTag("XRRig"); });
        GameObject xrRigOrigin = newSceneObjects.First((obj) => { return obj.CompareTag("XRRigOrigin"); });

        if (xrRig && xrRigOrigin)
        {
            xrRig.transform.position = xrRigOrigin.transform.position;
            xrRig.transform.rotation = xrRigOrigin.transform.rotation;
        }
    }
}
