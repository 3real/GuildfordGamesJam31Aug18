using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shredpaper : MonoBehaviour {

public float speed = 1f;
	public GameObject Paper;
	public GameObject Confetti;

	private Rigidbody myRigidbody;
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
	}
	
	void FireConfetti () {
    Rigidbody confettiClone = Instantiate(Confetti, transform.position, transform.rotation).GetComponent<Rigidbody>();
	confettiClone.transform.Translate(0.0f, 0.0f, 0.0f);
	}
	
	void Update () {
		
	//if (Input.GetKeyDown (KeyCode.W)) {
	//		myRigidbody.velocity = new Vector3 (0, speed, 0);
	//	}
	//}
	float h = speed * Input.GetAxis("Vertical");
	myRigidbody.velocity = new Vector3 (0,h,0);

	if (transform.position.y < 1) 
		{
			FireConfetti();
			
			Destroy(gameObject);
		}
	}
	
}
