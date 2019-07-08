using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rigidboddy;
    public float forward_force = 10f;
    public float backward_force = -10f;
    public float left_force = -10f;
    public float right_force = 10f;
    public float jump_force = 150f;
    bool jumpingcheck = false;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && transform.position.y <1.25)
        {
            jumpingcheck = true;
            
            
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rigidboddy.AddForce(right_force, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rigidboddy.AddForce(0, 0, forward_force);
        }
        if (Input.GetKey("s"))
        {
            rigidboddy.AddForce(0, 0, backward_force);
        }
        if (Input.GetKey("a"))
        {
            rigidboddy.AddForce(left_force, 0, 0);
        }
        if (jumpingcheck)
        {
            rigidboddy.AddForce(0, jump_force, 0);
            jumpingcheck = false;
        }
    }
}
