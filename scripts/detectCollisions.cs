using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollisions : MonoBehaviour
{
    void Start()
    {
        Console.WriteLine("script");
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        Console.WriteLine("collision");
    }
}
