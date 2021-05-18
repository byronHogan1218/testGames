using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RolingBallController : MonoBehaviour
{
    Rigidbody ballRb;
    [SerializeField]float speed = 5;
    float xForce = 0;
    float zForce = 0;
    bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        ballRb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            ballRb.AddForce(new Vector3(0, 250, 0));
            Debug.Log("Jump");
        }

        if(Input.GetAxis("Horizontal") != 0)
        {
            xForce = speed * Input.GetAxis("Horizontal") * -1;
        }
        else
        {
            xForce = 0;
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            zForce = speed * Input.GetAxis("Vertical") * -1;
        }
        else
        {
            zForce = 0;
        }
    }

    private void FixedUpdate()
    {
        ballRb.AddForce(xForce, 0, zForce);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
