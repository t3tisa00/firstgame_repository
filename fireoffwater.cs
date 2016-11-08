using UnityEngine;
using System.Collections;

public class fireoffwater : MonoBehaviour {
	float distance =10;
	public GameObject fireoff;
	//public AudioClip audio;

	// Use this for initialization
	void Start () {

	}
	void OnMouseDrag()
	{
		//Debug.Log ("Mouse drag");
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

		transform.position = objPosition;


	}
	void OnTriggerEnter(Collider other){
		//Debug.Log ("Collider: " + other.tag);
		if(other.CompareTag("water"))
		{			
			this.gameObject.SetActive (false);
			//Destroy (this.gameObject);
		}
		/*
		if(other.CompareTag("water")){

		//ResultText.text = "fire is formed ";
		//DestroyObject (other);

		//Destroy (gameObject);
		//gameObject.fireoff.SetActive (false);
		

			this.gameObject.SetActive(false);
			Destroy (this.gameObject);

		fireoff.SetActive (false);
		//AudioSource audio = GetComponent<AudioSource> ();
		//audio.Play ();
*/


	
	// Update is called once per frame
	
//}
}
}