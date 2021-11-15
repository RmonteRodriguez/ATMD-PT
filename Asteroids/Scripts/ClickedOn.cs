using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedOn : MonoBehaviour
{
    public AsteroidManager asteroidManager;

    public AudioSource explodeSFX;

    public bool isAsteroid;

    void OnMouseDown()
    {
        Destroy(gameObject);
        if (isAsteroid)
        {
            asteroidManager.numOfAsteroids = asteroidManager.numOfAsteroids - 1;
            explodeSFX.Play();
        }
    }
}
