using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
    
    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate() //For using physic rules properly we used FixedUpdate instead of update
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a force  on the z-axis

        if ( Input.GetKey("d") ) //D tu�una bast���m�zda sa�a do�ru kuvvet ekleyen bir kod
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) //A tu�una bast���m�zda sola do�ru kuvvet ekleyen bir kod
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
