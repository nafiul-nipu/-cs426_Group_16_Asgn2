using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour
{

    //Array for Mesh Renderer of Children
    public Component[] Renderer;

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
            return;

        var x = Input.GetAxis("Horizontal") * 0.1f;
        var z = Input.GetAxis("Vertical") * 0.1f;

        transform.Translate(x, 0, z);
    }

    
    public override void OnStartLocalPlayer()
    {

        Renderer[] rs = GetComponentsInChildren<Renderer>();

        foreach (Renderer r in rs)
        {
            //r.enabled = false;            //Enables Mesh Renderer
            r.material.color = Color.red;
        }



        //GetComponent<MeshRenderer>().material.color = Color.red;


    }
    
}
