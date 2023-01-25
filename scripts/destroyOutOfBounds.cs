using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -3.0f;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }
    }
}
