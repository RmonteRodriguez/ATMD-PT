using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundManager : MonoBehaviour
{
    public GameManager gameManager;

    public int nextLevel;

    public float time;
    public float initialTimer;
    public float decreasePerSecond;

    public bool isRacer;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        time = initialTimer;
    }

    // Update is called once per frame
    void Update()
    {
        time -= decreasePerSecond * Time.deltaTime;

        if (time <= 0)
        {
            gameManager.lives = gameManager.lives - 1;
            SceneManager.LoadScene(nextLevel);

            if (isRacer)
            {
                gameManager.lives = gameManager.lives + 1;
            }
        }
    }
}
