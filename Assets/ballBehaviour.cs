using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallBehaviour : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private Vector3 moveObject;
    private Transform myTransform;
    private Vector3 initialPosition;

    [SerializeField] private float speed = 10f;

    private void Start()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody>();
        myTransform = this.gameObject.GetComponent<Transform>();
        initialPosition = myTransform.position;
    }

    void Update()
    {
        moveObject = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.useGravity = true;
            myRigidbody.constraints = RigidbodyConstraints.FreezePositionX;
        }

        if (!myRigidbody.useGravity)
        {
            myRigidbody.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionX;

            if (Input.GetKey(KeyCode.A))
            {
                moveObject.z += 1;
            }

            if (Input.GetKey(KeyCode.D))
            {
                moveObject.z -= 1;
            }
        }

        Vector3 objectPosition = transform.position;
        objectPosition += moveObject.normalized * speed * Time.deltaTime;
        transform.position = objectPosition;

        if (Input.GetKeyDown(KeyCode.R))
        {
            myRigidbody.useGravity = false;
            transform.position = initialPosition;
        }
    }
}
