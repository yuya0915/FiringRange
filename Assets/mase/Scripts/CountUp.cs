using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountUp : MonoBehaviour
{
    private float timecount = 0.0f;


    public Text timetext;
    public bool Countflg;
    // Start is called before the first frame update
    void Start()
    {
        Countflg = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (Countflg == true)
        {
            timecount += Time.deltaTime;
            Debug.Log(timecount);
        }
        else
        {
            timetext.text = timecount.ToString("f1") + "秒";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Start")
        {
            Debug.Log("ヒット");
            Countflg = true;
        }

        if (other.gameObject.tag == "Goal")
        {
            Countflg = false;
        }
    }
}
