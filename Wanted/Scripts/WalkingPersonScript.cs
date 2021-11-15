using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WalkingPersonScript : MonoBehaviour
{
    //Variables
    public float moveSpeed;
    public float walkTime;
    public float waitTime;
    private float walkCounter;
    private float waitCounter;

    public Rigidbody2D rb;

    public bool isWalking;
    public bool isWanted;

    private int walkDirection;

    public int nextLevel;

    public AudioSource explodeSFX;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        waitCounter = waitTime;
        walkCounter = walkTime;

        ChooseDirection();
    }

    void Update()
    {
        if (isWalking)
        {
            walkCounter -= Time.deltaTime;

            switch (walkDirection)
            {
                case 0:
                    rb.velocity = new Vector2(0, moveSpeed);
                    break;
                case 1:
                    rb.velocity = new Vector2(moveSpeed, 0);
                    break;
                case 2:
                    rb.velocity = new Vector2(0, -moveSpeed);
                    break;
                case 3:
                    rb.velocity = new Vector2(-moveSpeed, 0);
                    break;
                case 4:
                    rb.velocity = new Vector2(-moveSpeed, moveSpeed);
                    break;
                case 5:
                    rb.velocity = new Vector2(moveSpeed, -moveSpeed);
                    break;
                case 6:
                    rb.velocity = new Vector2(moveSpeed, moveSpeed);
                    break;
                case 7:
                    rb.velocity = new Vector2(-moveSpeed, -moveSpeed);
                    break;
            }

            if (walkCounter < 0)
            {
                waitTime = Random.Range(0, 1);
                isWalking = false;
                waitCounter = waitTime;
            }
        }
        else
        {
            waitCounter -= Time.deltaTime;

            rb.velocity = Vector2.zero;

            if (waitCounter < 0)
            {
                ChooseDirection();
            }
        }
    }

    void OnMouseDown()
    {
        if (isWanted)
        {
            explodeSFX.Play();
            Destroy(gameObject);
            SceneManager.LoadScene(nextLevel);
        }
    }

    public void ChooseDirection()
    {
        walkTime = Random.Range(0, 2);
        walkDirection = Random.Range(0, 9);
        isWalking = true;
        walkCounter = walkTime;
    }
}
