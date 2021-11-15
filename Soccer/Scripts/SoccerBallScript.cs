using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoccerBallScript : MonoBehaviour
{
    public int nextLevel;

    public AudioSource portalSFX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "goal")
        {
            portalSFX.Play();
            Destroy(gameObject);
            SceneManager.LoadScene(nextLevel);
        }
    }
}
