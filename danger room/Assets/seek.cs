using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seek : MonoBehaviour {
	Rigidbody rb;
	Vector3 targetPos;
	public GameObject targetObj;
    public GameObject berr;
	public float powerAnt = 10f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(targetObj !=null){
			targetPos = targetObj.transform.position;
			Vector3 direction = Vector3.Normalize (targetPos - transform.position);
			rb.AddForce (direction * powerAnt);
		}
	}
	void OnCollision(Collision col){
		if (col.gameObject == targetObj) {
			Destroy (targetObj);
		}

	}
}
