using System.Collections;
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

    Rigidbody rb;
    Transform t;

    //Initializing (Replaces Start())
    public override void OnStartLocalPlayer()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent <Transform>();


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
        if (Input.GetKey(KeyCode.W))
            rb.velocity += this.transform.forward * speed * Time.deltaTime;                 // Move Forwards
        else if (Input.GetKey(KeyCode.S))                                                   // Move Backwards
            rb.velocity -= this.transform.forward * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);           // Rotate Right
        else if (Input.GetKey(KeyCode.A))
            t.rotation *= Quaternion.Euler(0, -rotationSpeed * Time.deltaTime, 0);          // Rotate Left

        if (Input.GetKeyDown(KeyCode.Space))                                                // Increase Altitude
            rb.AddForce(t.up * force);

        if (Input.GetKeyDown(KeyCode.LeftShift))                                            // Lower Altitude
            rb.AddForce(t.up * -force);

        // ----------------------------------------------------
        //                  Interact Control
        // ----------------------------------------------------

        if (Input.GetKeyDown(KeyCode.E))
        {
            //Implement Something to pick up object
            Debug.Log("Claiming Nest~!");
        }



    }
}
