using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehaviour : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        print("Ganaste un punto!");
    }
}
