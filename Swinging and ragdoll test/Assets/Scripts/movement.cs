using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody moveee;
    // Start is called before the first frame update
    void Start()
    {
       moveee = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(Input.GetKey("w"))
       {
          moveee.AddForce(new Vector3(0f, 0f, 20f)); 
       } 
       if(Input.GetKey("s"))
       {
           moveee.AddForce(new Vector3(0f, 0f, -20f));
       }
       if(Input.GetKey("a"))
       {
           moveee.AddForce(new Vector3(-20f, 0f, 0f));
       }
       if(Input.GetKey("d"))
       {
           moveee.AddForce(new Vector3(20f, 0f, 0f));
       }
    }
}
