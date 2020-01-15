using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    CharacterController characterController;
    public float speed;
    public float jumpSpeed;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;



    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetKey(KeyCode.Space))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);


            //if (Input.GetKey(KeyCode.W))
            //{
            //    transform.position += transform.forward * speed * Time.deltaTime;
            //}
            //if (Input.GetKey(KeyCode.S))
            //{
            //    transform.position -= transform.forward * speed * Time.deltaTime;
            //}
            //if (Input.GetKey(KeyCode.D))
            //{
            //    transform.position += transform.right * speed * Time.deltaTime;
            //}
            //if (Input.GetKey(KeyCode.A))
            //{
            //    transform.position -= transform.right * speed * Time.deltaTime;
            //}
        }
}
