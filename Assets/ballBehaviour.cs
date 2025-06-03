using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private Vector3 moveObject;

    [SerializeField] private float speed = 10f;

    private void Start()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveObject = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.useGravity = true;
        }

        if (!myRigidbody.useGravity)
        {
            if (Input.GetKey(KeyCode.A))
            {
                moveObject.z += 1;
            }

            if (Input.GetKey(KeyCode.D))
            {
                moveObject.z -= 1;
            }
        }

        Vector3 myPos = transform.position;
        myPos += moveObject.normalized * speed * Time.deltaTime;
        transform.position = myPos;
    }
}
