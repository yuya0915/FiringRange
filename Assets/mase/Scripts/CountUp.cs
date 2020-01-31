using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountUp : MonoBehaviour
{
    private float timecount = 0.0f;


    public Text timetext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        timecount += Time.deltaTime;

        timetext.text = timecount.ToString("f1") + "秒";
    }
}
