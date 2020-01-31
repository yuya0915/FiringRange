using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountUp : MonoBehaviour
{
    private float countup = 0.0f;

    public Text timetext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countup += Time.deltaTime;

        timetext.text = countup.ToString("f1") + "秒";
    }
}
