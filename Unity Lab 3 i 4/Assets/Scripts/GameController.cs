using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject OneBallPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddBall", 1.5f, 1f);
    }

    void AddBall()
    {
        Instantiate(OneBallPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
