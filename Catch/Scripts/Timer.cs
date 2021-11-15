using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time;
    public float initialTimer;
    public float decreasePerSecond;

    // Start is called before the first frame update
    void Start()
    {
        time = initialTimer;
    }

    // Update is called once per frame
    void Update()
    {
        time -= decreasePerSecond * Time.deltaTime;

        if (time <= 0)
        {
            Destroy(gameObject);
        }
    }
}
