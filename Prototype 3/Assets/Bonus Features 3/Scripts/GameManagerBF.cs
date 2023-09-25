using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBF : MonoBehaviour
{
    public float score;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
