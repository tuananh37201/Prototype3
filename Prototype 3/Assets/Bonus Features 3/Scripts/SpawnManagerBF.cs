using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerBF : MonoBehaviour
{
    public GameObject[] SpawnPrefab;
    public float delayStart = 2f;
    public float timemer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", delayStart, timemer);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void SpawnObstacle()
    {
        int randomSpawn = Random.Range(0, SpawnPrefab.Length);
        Instantiate(SpawnPrefab[randomSpawn], gameObject.transform.position, SpawnPrefab[0].transform.rotation);
    }
}
