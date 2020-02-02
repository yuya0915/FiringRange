using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //CharacterController characterController;
    //public float speed;
    //public float jumpSpeed;
    //public float gravity = 20.0f;

    //private Vector3 moveDirection = Vector3.zero;

    public GameObject Player;
    public GameObject Camera;
    private Transform PlayerTransform;
    private Transform CameraTransform;
    public float speed;
    private float ii;
    AudioSource audioSource;
    public AudioClip audio;


    // Start is called before the first frame update
    void Start()
    {
        //characterController = GetComponent<CharacterController>();
        //PlayerTransform = transform.parent;
        //CameraTransform = GetComponent<Transform>();
        PlayerTransform = transform.parent;
        CameraTransform = GetComponent<Transform>();
        audioSource =this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        PlayerTransform.transform.Rotate(0, X_Rotation, 0);

        ii = Camera.transform.localEulerAngles.x;

        if (ii > 334 && ii < 360 || ii > 0 && 79 > ii)
        {
            CameraTransform.transform.Rotate(-Y_Rotation, 0, 0);
            float kk = Y_Rotation;
        }
        else
        {
            if (ii > 300)
            {
                if (Input.GetAxis("Mouse Y") < 0)
                {
                    CameraTransform.transform.Rotate(-Y_Rotation, 0, 0);
                }
            }
            else
            {
                if (Input.GetAxis("Mouse Y") > 0)
                {
                    CameraTransform.transform.Rotate(-Y_Rotation, 0, 0);
                }
            }
        }
        float angleDir = PlayerTransform.transform.eulerAngles.y * (Mathf.PI / 180.0f);
        Vector3 dir1 = new Vector3(Mathf.Sin(angleDir), 0, Mathf.Cos(angleDir));
        Vector3 dir2 = new Vector3(-Mathf.Cos(angleDir), 0, Mathf.Sin(angleDir));

        if (Input.GetKey(KeyCode.W))
        {

            audioSource.Play();
            PlayerTransform.transform.position += dir1 * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            audioSource.Stop();
        }
        if (Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.LeftShift))
        {
            PlayerTransform.transform.position += dir1 * speed * 1.5f* Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            PlayerTransform.transform.position += dir2 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.LeftShift))
        {
            PlayerTransform.transform.position += dir2 * speed *1.5f* Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            PlayerTransform.transform.position += -dir2 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            PlayerTransform.transform.position += -dir2 * speed *1.5f* Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            PlayerTransform.transform.position += -dir1 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            PlayerTransform.transform.position += -dir1 * speed *1.5f* Time.deltaTime;
        }

        //if (characterController.isGrounded)
        //{
        //    moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        //    moveDirection *= speed;

        //    if (Input.GetKey(KeyCode.Space))
        //    {
        //        moveDirection.y = jumpSpeed;
        //    }
        //}
        //moveDirection.y -= gravity * Time.deltaTime;
        //characterController.Move(moveDirection * Time.deltaTime);

        //CameraRotationMouseControl();


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


    //public void CameraRotationMouseControl()
    //{
    //    float X_Rotation = Input.GetAxis("Mouse X");
    //    float Y_Rotation = Input.GetAxis("Mouse Y");
    //    PlayerTransform.transform.Rotate(0, X_Rotation, 0);
    //    CameraTransform.transform.Rotate(-Y_Rotation, 0, 0);


    //    float angleDir = PlayerTransform.transform.eulerAngles.y * (Mathf.PI / 180.0f);
    //    Vector3 dir1 = new Vector3(Mathf.Sin(angleDir), 0, Mathf.Cos(angleDir));
    //    Vector3 dir2 = new Vector3(-Mathf.Cos(angleDir), 0, Mathf.Sin(angleDir));
    //}
}

