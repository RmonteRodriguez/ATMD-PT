using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyObject : MonoBehaviour
{
    public bool isTargetPractice;
    public int nextScene;

    public AudioSource explodeSFX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        if (isTargetPractice)
        {
            explodeSFX.Play();
            SceneManager.LoadScene(nextScene);
        }
    }
}
