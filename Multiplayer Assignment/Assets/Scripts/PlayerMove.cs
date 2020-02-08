﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour
{

    //Array for Mesh Renderer of Children
    private Component[] Renderer;

    float speed = 25.0f;
    float rotationSpeed = 90;
    float force = 200f;

    //Rigidbody rb;
    //Transform t;

    //Initializing (Replaces Start())
    public override void OnStartLocalPlayer()
    {
        //rb = GetComponent<Rigidbody>();
        //t = GetComponent <Transform>();


        Renderer[] rs = GetComponentsInChildren<Renderer>();

        foreach (Renderer r in rs)
        {
            //r.enabled = false;            //Enables Mesh Renderer
            r.material.color = Color.red;
        }

    }


    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
            return;

        // ----------------------------------------------------
        //                  Basic Movement Set
        // ----------------------------------------------------
        
        //Movement for Forward / Backwards
        var x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        //Movement for Left / Right
        var z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //Movement for Up / Down
        var y = 0.0f;
        
        //Rotations
        if (Input.GetKey(KeyCode.Q))
            // Rotate Right
            transform.rotation *= Quaternion.Euler(0, -rotationSpeed * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.E))
            // Rotate Left
            transform.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.Space))
        {                                              
            // Increase Altitude
            //Debug.Log("Flying UP~!");
            y = 1.0f * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // Lower Altitude
            //Debug.Log("Flying DOWN~!");
            y = -1.0f * speed * Time.deltaTime;
        }

        
        //Main Movement 
        transform.Translate(x, y, z);   
        
        // ----------------------------------------------------
        //                  Interact Control
        // ----------------------------------------------------

        if (Input.GetKeyDown(KeyCode.F))
        {
            //Implement Something to pick up object
            Debug.Log("Claiming Nest~!");
        }



    }
}
