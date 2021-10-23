using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransitionController : MonoBehaviour
{
    public string scene;

    public void TransitionScene()
    {
        SceneLoader.Instance.TransitionTo(scene);
    }
}
