using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public Vector3 spawnPosition = new Vector3(20.0f, 2.0f, 0.0f);

    public float starDelay = 2;
    public float repeatRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", starDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {
        int randomObstacle = Random.Range(0, obstaclePrefab.Length);
        Instantiate(obstaclePrefab[randomObstacle], spawnPosition, transform.rotation);
    }
}
