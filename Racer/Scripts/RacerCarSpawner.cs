using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacerCarSpawner : MonoBehaviour
{
    //Variables
    public GameObject obstaclePrefab;

    [SerializeField]
    private float respawnTime = 1.0f;

    private Vector2 screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(carWave());
    }

    void Update()
    {
        respawnTime = respawnTime - 0.01f * Time.deltaTime;
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));
    }
    IEnumerator carWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
