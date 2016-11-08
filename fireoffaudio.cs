using UnityEngine;
using System.Collections;

public class fireoffaudio : MonoBehaviour {

	// Use this for initialization
	//public AudioClip impact;
	AudioSource audio;
	public GameObject smokeon;

	void Start () {
		audio =GameObject.Find("Audio"). GetComponent<AudioSource> ();
		audio.Stop ();
		//audio.Play ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		//Debug.Log ("Collider: " + other.name);
		if(other.CompareTag("Fire"))
		{			
			audio.Play ();
			smokeon.SetActive (true);
			//this.gameObject.SetActive (false);
		}

		
		
	}
}
