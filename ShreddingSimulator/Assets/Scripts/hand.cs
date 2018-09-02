using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour {

public float speed = 1f;
	public GameObject Paper;
	public GameObject Butterfly;
	public AudioClip rip;
    AudioSource audioSource;
	private Rigidbody myRigidbody;

	bool soundCanPlay = true;
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource>();
	}
	
	void FireButterfly () {
    Rigidbody butterflyClone = Instantiate(Butterfly, transform.position, transform.rotation).GetComponent<Rigidbody>();
	butterflyClone.transform.Translate(0.4f, 1.0f, 0.0f);
	butterflyClone.transform.Rotate(90,0,0);
	butterflyClone.AddForce(0,10,0);
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
	
	if (transform.position.y < 2.2 && soundCanPlay == true) 
		{
			audioSource.PlayOneShot(rip, 2.0F);
			soundCanPlay = false;
		}
	if (transform.position.y >2.2) 
		{
			soundCanPlay = true;
		}
	}
	
}

