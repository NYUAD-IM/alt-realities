using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchAnimationCallbacks : MonoBehaviour
{
    public AudioSource sound1;
    public AudioSource sound2;

    public void PlaySound1()
    {
        sound1.Play();
    }

    public void PlaySound2()
    {
        sound2.Play();
    }
}
