using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform Dest = null; //Destination Player will be teleported to.

    public void OnTriggerEnter(Collider other)
    {
        //When the object is allowed to teleport
        if (other.gameObject.tag == "Teleport") //Tag object to activate teleportation
            this.transform.position = Dest.position;
    }
}