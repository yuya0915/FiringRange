using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayControl : MonoBehaviour
{

    public Camera camera_obj;//Cameraを取得
    private RaycastHit hit;//レイが当たったモノを取得

    public Text Hittext;//テキスト
    public int HitCount;//当たったカウント

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Ray ray = new Ray(camera_obj.transform.position, transform.forward);

            if (Physics.Raycast(camera_obj.transform.position,transform.forward,out hit,5))
            {
                Destroy(hit.collider.gameObject);
                HitCount += 1;//消したカウント
                Debug.Log(HitCount);
                Debug.DrawRay(camera_obj.transform.position, transform.forward, Color.blue);
            }
        }

        Hittext.text = HitCount.ToString();

    }
}
