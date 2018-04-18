using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrust : MonoBehaviour {

    public GameObject winspot;
    public GameObject player;
	 public Rigidbody rb;
	public float powerANT;
    public AudioClip arClip;
    public AudioSource passt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			rb.AddForce (Vector3.forward * powerANT);
		}
		if (Input.GetKey (KeyCode.S)) {
			rb.AddForce (Vector3.back * powerANT);
		}
		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (Vector3.left * powerANT);
		}
		if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (Vector3.right* powerANT);
		}
        if(player.transform.position == winspot.transform.position)
        {
            passt.Play();

        }
	}
}
