using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float XRotation;
    public float YRotation;
    public float ZRotation;
    public float DegreesPerSecond = 180.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
        transform.RotateAround(Vector3.zero, axis, Time.deltaTime * DegreesPerSecond);
        Debug.DrawRay(Vector3.zero, axis, Color.yellow, .5f);
    }
}
