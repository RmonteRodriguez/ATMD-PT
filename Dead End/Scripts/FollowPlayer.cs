using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float speed;
    private Transform target;

    public string follow;

    public Vector2 movement;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag(follow).GetComponent<Transform>();

        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directrion = target.position - transform.position;
        //float angle = Mathf.Atan2(directrion.y, directrion.x) * Mathf.Rad2Deg * 90f;
        //rb.rotation = angle;
        movement = directrion;
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        speed = speed + 0.1f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
