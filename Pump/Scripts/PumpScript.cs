using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PumpScript : MonoBehaviour
{
    public GameManager gameManager;

    public float pumpInt;
    public float increasePerClick;
    public float initialValue;
    public float decreasePerSecond;

    public Transform UIBar;

    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    public int nextLevel;

    public AudioSource pumpSFX;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        pumpInt = initialValue;
    }

    // Update is called once per frame
    void Update()
    {
        pumpInt -= decreasePerSecond * Time.deltaTime;

        float t_ratio = pumpInt / initialValue;
        UIBar.localScale = new Vector3(t_ratio, 1, 1);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pumpInt = pumpInt + increasePerClick;
            pumpSFX.Play();
        }

        if (pumpInt >= 15)
        {
            spriteRenderer.sprite = sprites[0];
        }
        else if (pumpInt <= 15 & pumpInt >= 10)
        {
            spriteRenderer.sprite = sprites[1];
        }
        else
        {
            spriteRenderer.sprite = sprites[2];
        }

        if (pumpInt <= 0)
        {
            gameManager.lives = gameManager.lives - 1;
            SceneManager.LoadScene(nextLevel);
        }
    }
}
