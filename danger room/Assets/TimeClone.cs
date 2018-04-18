using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeClone : MonoBehaviour {
	public GameObject blueprint;
	public float cloneTime = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > cloneTime) {
			Debug.Log ("do that thing");
			Instantiate (blueprint, transform.position, Quaternion.identity);
			cloneTime += cloneTime;
		}
	}
}
