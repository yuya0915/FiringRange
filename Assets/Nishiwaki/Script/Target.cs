using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject TargetUpObject;

    TargetUp script;

    Animator animator;

    int r;
    // Start is called before the first frame update
    void Start()
    {
        script = TargetUpObject.GetComponent<TargetUp>();

        animator = GetComponent<Animator>();

        r = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        if (script.flg)
        {
            //animator.SetTrigger("Up");
            r += 5;
            if (r <= 90)
            {
                transform.Rotate(new Vector3(0f, 0f, 5f));
            }

        }
    }
}
