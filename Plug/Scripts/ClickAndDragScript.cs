using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickAndDragScript : MonoBehaviour
{
    public GameObject plug;

    private bool isInPlug;
    private bool isDragging;

    public Transform plugLocation;

    public int nextLevel;

    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging == true && isInPlug == false)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }

        if (isInPlug == true)
        {
            plug.transform.position = plugLocation.transform.position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isInPlug = true;
        Debug.Log("Hello World");
        SceneManager.LoadScene(nextLevel);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        isInPlug = true;
        Debug.Log("Hello World");
        SceneManager.LoadScene(nextLevel);
    }
}
