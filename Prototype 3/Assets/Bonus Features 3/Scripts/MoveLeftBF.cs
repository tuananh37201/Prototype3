using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class MoveLeftBF : MonoBehaviour
{
    private float leftBound = -10f;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if(gameObject.CompareTag("Obstacle") && transform.position.x < leftBound)
        {
            Destroy(gameObject);
        } 
    }
}
