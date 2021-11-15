using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPracticeAim : MonoBehaviour
{
    //Variables
    public Transform playerTransform;

    public Rigidbody2D rb;

    public Camera cam;

    public Vector3 mousePos;
    public Vector3 gunPos;
    public Vector3 offset;

    public float angle;

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        gunPos = cam.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - gunPos.x;
        mousePos.y = mousePos.y - gunPos.y;
        angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        transform.position = playerTransform.position - offset;
    }
}
