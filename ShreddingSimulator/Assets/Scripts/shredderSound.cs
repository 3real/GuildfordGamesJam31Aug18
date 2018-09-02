using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shredderSound : MonoBehaviour {

	// Use this for initialization
	public AudioClip bzzt;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.B))
			{
			audioSource.PlayOneShot(bzzt, 0.3F);
			
			}
	}
}
