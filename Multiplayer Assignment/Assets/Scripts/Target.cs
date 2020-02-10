﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Score scoreManager;

    private void OnCollisionEnter(Collision collision) {
        scoreManager.AddPoint();

        Debug.Log("Collided with: ");
        Debug.Log(collision.gameObject.name);

        Debug.Log("Collision Detected");
        Destroy(gameObject);
    }
}
