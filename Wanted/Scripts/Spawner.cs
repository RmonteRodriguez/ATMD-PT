using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wantedPerson;

    public Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        Transform t_spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(wantedPerson, t_spawn.position, t_spawn.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
