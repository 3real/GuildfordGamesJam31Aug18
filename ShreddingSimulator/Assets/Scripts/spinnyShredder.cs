using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinnyShredder : MonoBehaviour {

	
	public float speed = 500f;
	public GameObject Shredder;
	private Rigidbody myRigidbody;
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
	}
	
	
	void Update () {
		
		//float h = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		//myRigidbody.AddTorque(transform.up * h);

	if (Input.GetKeyDown(KeyCode.B))
			{
			//transform.RotateAround (Shredder.transform.position, Shredder.transform.forward, speed * Time.deltaTime);
			myRigidbody.AddTorque(transform.forward * speed);
			
			}
	}
}

