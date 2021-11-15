using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatchScript : MonoBehaviour
{
    public GameManager gameManager;

    private bool isInTrigger;

    public GameObject[] objects;

    public int nextLevel;

    public AudioSource explodeSFX;


    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        isInTrigger = false;
        RandomObject();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isInTrigger == true)
            {
                explodeSFX.Play();
                Destroy(gameObject);
                SceneManager.LoadScene(nextLevel);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        isInTrigger = true;    
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isInTrigger = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Barrier")
        {
            gameManager.lives = gameManager.lives - 1;
            SceneManager.LoadScene(nextLevel);
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void RandomObject()
    {
        int newIndex = Random.Range(0, objects.Length);
        objects[newIndex].SetActive(true);
    }
}
