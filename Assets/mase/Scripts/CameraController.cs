using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    public float speed;
    private Transform PlayerTransform;
    private Transform CameraTransform;




    // Start is called before the first frame update
    void Start()
    {
        PlayerTransform = transform.parent;
        CameraTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotationMouseControl();

        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");
    }

    private void CameraRotationMouseControl()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        PlayerTransform.transform.Rotate(0, X_Rotation, 0);
        CameraTransform.transform.Rotate(-Y_Rotation, 0, 0);


        float angleDir = PlayerTransform.transform.eulerAngles.y * (Mathf.PI / 180.0f);
        Vector3 dir1 = new Vector3(Mathf.Sin(angleDir), 0, Mathf.Cos(angleDir));
        Vector3 dir2 = new Vector3(-Mathf.Cos(angleDir), 0, Mathf.Sin(angleDir));
    }
}
