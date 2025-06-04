using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacles : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f;

    void Update()
    {
        int rotationZ = 0;

        if (Input.GetKey(KeyCode.W))
        {
            rotationZ = 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rotationZ = -1;
        }

        transform.Rotate(0f, 0f, rotationZ * rotationSpeed * Time.deltaTime);
    }
}
