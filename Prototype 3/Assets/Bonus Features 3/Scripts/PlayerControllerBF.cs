using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBF : MonoBehaviour
{
    private Rigidbody rb;

    private float jumpForce = 10f;
    private float gravityModifier = 2f;
    private bool isGrounded;
    private int jumpTimes = 2;
    private float lastJumpTime;
    private float jumpDelay = 0.5f; // Thời gian chờ giữa các lần nhảy

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && jumpTimes > 0 && Time.time - lastJumpTime > jumpDelay)
        {
            jumpTimes--;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            lastJumpTime = Time.time;
        }

        if (jumpTimes == 0)
        {
            isGrounded = false;
        }

        // Dash
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Time.timeScale = 2f;
        }
        else Time.timeScale = 1f;

        // Player starting off running
        if(transform.position.x <= -9f)
        {
            transform.Translate(Vector3.forward * 3f * Time.deltaTime );
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpTimes = 2;
        }


        if (collision.collider.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
        }
    }
}
