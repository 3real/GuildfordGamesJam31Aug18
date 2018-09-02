﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour {

public float speed = 1f;
	public GameObject Paper;
	public GameObject Butterfly;
	private Rigidbody myRigidbody;
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
	}
	
	void FireButterfly () {
    Rigidbody butterflyClone = Instantiate(Butterfly, transform.position, transform.rotation).GetComponent<Rigidbody>();
	butterflyClone.transform.Translate(0.0f, 0.0f, 0.0f);
	}
	void Update () {
		
	//if (Input.GetKeyDown (KeyCode.W)) {
	//		myRigidbody.velocity = new Vector3 (0, speed, 0);
	//	}
	//}
	float h = speed * Input.GetAxis("Vertical");
	myRigidbody.velocity = new Vector3 (0,h,0);

	if (transform.position.y < 0.5) 
		{
			FireButterfly();
			Destroy(this.gameObject);
		}
	}
	
}

