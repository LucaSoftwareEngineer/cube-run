using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float spintaInAvanti;
    public float spintaLaterale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void FixedUpdate()
    {

        // La spinta in avanti del player è costante
        rigidbody.AddForce(0, 0, -spintaInAvanti);

        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(spintaLaterale, 0, 0);
        }

        if (Input.GetKey("d")) {
            rigidbody.AddForce(-spintaLaterale, 0, 0);
        }

    }
}
