using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float delay = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (delay < 0f)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                delay = 1f;
            }
        }
        delay -= Time.deltaTime;
    }
}
