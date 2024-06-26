﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
public float lowerBound;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

     void Update()
    {
        if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
