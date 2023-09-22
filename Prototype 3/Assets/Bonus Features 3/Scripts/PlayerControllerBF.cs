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
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && jumpTimes > 0)
        {
            jumpTimes--;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            if (jumpTimes == 0)
            {
                isGrounded = false;
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpTimes = 2;
        }
    }
}
