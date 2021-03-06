using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    //Variables

    public Transform movingPlatform;
    public Transform position1;
    public Transform position2;
    public Vector2 newPostion;
    public string currentState;
    public float smooth;
    public float resetTime;

    // Use this for initialization
    void Start()
    {
        ChangeTarget();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movingPlatform.position = Vector2.Lerp(movingPlatform.position, newPostion, smooth * Time.deltaTime);
    }

    void ChangeTarget()
    {
        if (currentState == "Moving To Position 1")
        {
            currentState = "Moving To Position 2";
            newPostion = position2.position;
        }
        else if (currentState == "Moving To Position 2")
        {
            currentState = "Moving To Position 1";
            newPostion = position1.position;
        }
        else if (currentState == "")
        {
            currentState = "Moving To Position 2";
            newPostion = position2.position;
        }
        Invoke("ChangeTarget", resetTime);
    }
}
