using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private Transform myTransform;

    private void Start()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody>();
        myTransform = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.useGravity = true;
        }
    }
}
