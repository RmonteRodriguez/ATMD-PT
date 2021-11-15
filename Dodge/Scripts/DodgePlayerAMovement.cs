using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgePlayerAMovement : MonoBehaviour
{
    public GameObject player;

    public Transform position1;
    public Transform position2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position = position1.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position = position2.transform.position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Debug.Log("Hello World");
    }
}
