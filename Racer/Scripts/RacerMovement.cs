using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RacerMovement : MonoBehaviour
{
    //Variables
    public GameManager gameManager;

    private float speed = 5f;

    public Rigidbody2D rb;

    public int nextLevel;

    public AudioSource explodeSFX;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0.0f, 1.0f, 0.0f);
            gameObject.GetComponent<Rigidbody2D>().velocity *= speed;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0.0f, -1.0f, 0.0f);
            gameObject.GetComponent<Rigidbody2D>().velocity *= speed;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "car")
        {
            explodeSFX.Play();
            gameManager.lives = gameManager.lives - 1;
            Destroy(gameObject);
            SceneManager.LoadScene(nextLevel);
        }
    }
}
