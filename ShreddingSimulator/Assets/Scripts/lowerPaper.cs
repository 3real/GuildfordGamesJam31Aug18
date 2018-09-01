using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowerPaper : MonoBehaviour {

	public float speed = 1f;
	public GameObject Paper;
	private Rigidbody myRigidbody;

	void Start () {
		myRigidbody = this.gameObject.GetComponent<Rigidbody> ();
	}

void FirePaper () {
    Rigidbody paperClone = Instantiate(Paper, transform.position, transform.rotation).GetComponent<Rigidbody>();

}

// Calls the fire method when holding down ctrl or mouse
void Update () {
    if (Input.GetButtonDown("Fire1")) {
        FirePaper();
    }
}

	
	//void Update () {
		
	//if (Input.GetKeyDown (KeyCode.W)) {
	//		myRigidbody.velocity = new Vector3 (0, speed, 0);
	//	}
	//}
	//float h = speed * Input.GetAxis("Vertical");
	//myRigidbody.velocity = new Vector3 (0,h,0);
	//}
	
}
