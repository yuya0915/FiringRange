using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerjump : MonoBehaviour
{

    public GameObject Player;
    private Rigidbody Rb;
    public float jjumpSpeed;

    // Start is called before the first frame update
    void Start()
    {

        Rb = Player.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground"&&Input.GetKeyDown(KeyCode.Space))
        {
            Rb.AddForce(transform.up * jjumpSpeed);
            Debug.Log("a");
        }
    }
}
