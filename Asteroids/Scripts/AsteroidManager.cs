using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroidManager : MonoBehaviour
{
    public int numOfAsteroids;
    public int nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        numOfAsteroids = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (numOfAsteroids <= 0)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
