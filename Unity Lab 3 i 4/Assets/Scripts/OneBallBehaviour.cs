using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneBallBehaviour : MonoBehaviour
{
    static int _nextBallNumber = 1;
    
    public float XRotation = 0f;
    public float YRotation = 1f;
    public float ZRotation = 0f;
    public float DegreesPerSecond = 180f;
    public int BallNumber = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(3 - Random.value * 6, 3 - Random.value * 6, 3 - Random.value * 6);
        BallNumber = _nextBallNumber++;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
        transform.RotateAround(Vector3.zero, axis, DegreesPerSecond * Time.deltaTime);
    }
}
