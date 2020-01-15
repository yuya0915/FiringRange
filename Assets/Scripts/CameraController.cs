using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform _camTransform;//cameraのtransformer

    private Vector3 _startMousePos;//マウス操作の始点

    private Vector3 _presentCamRotation;//Cameraの回転の始点情報




    // Start is called before the first frame update
    void Start()
    {
        _camTransform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotationMouseControl();
    }

    private void CameraRotationMouseControl()
    {

    }
}
