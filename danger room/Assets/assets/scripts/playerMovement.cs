using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    public Rigidbody rb;
    public bool onGrond;
    public float powerAnt;
    public GameObject MyBoy;
    


	// Use this for initialization
	void Start () {
        onGrond = true;
        rb = GetComponent<Rigidbody>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (onGrond)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector3(0f, 6f, 0f);
                onGrond = false;
            }
           
        }
       
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.left * powerAnt);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(Vector3.right * powerAnt);
}
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.back* powerAnt);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector3.forward * powerAnt);
        }
    }
   void OnCollisionEnter (Collision any)
        {
            any.gameObject.CompareTag("ground");
            onGrond = true;
        }

}
