using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpAnimation : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float duration = 4;

    float currentT = 0;
    AnimationCurve curve = AnimationCurve.EaseInOut(0,0,1,1);

    // Start is called before the first frame update
    void Start()
    {
        currentT = 0;
        transform.position = start.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != end.position)
        {
            currentT += Time.deltaTime / duration;
            currentT = Mathf.Clamp01(currentT);
            float t = curve.Evaluate(currentT);
            transform.position = Vector3.Lerp(start.position, end.position, t);
            transform.rotation = Quaternion.Slerp(start.rotation, end.rotation, t);
        }
    }
}
