using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    [SerializeField] float gravity = 1f;
    [SerializeField] float jumpheight = 20f;

    CharacterController controller;

    float yVelocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {

        float horizontalIpnut = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontalIpnut, 0, 0);
        Vector3 velocity = direction * speed;

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpheight;
            }
        }
        else
        {
            yVelocity -= gravity;
        }

        velocity.y = yVelocity;

        controller.Move(velocity * Time.deltaTime);
    }
}
