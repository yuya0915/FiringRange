using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public GameObject gameObject;
    TargetUp tscript;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        tscript = gameObject.GetComponent<TargetUp>();
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (tscript.flg)
        {
            i += 5;
            if (i <=90)
            {
                transform.Rotate(new Vector3(0f, 0f, 5f));
            }
        }
    }
}
