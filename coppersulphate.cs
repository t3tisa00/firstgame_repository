using UnityEngine;
using System.Collections;

public class coppersulphate : MonoBehaviour {
	float distance =10;
	public GameObject firechange;
	public Color color;
	// Use this for initialization
	//public Material[] material;
	//Renderer rend;
	void Start () {
	///	rend = GetComponent<Renderer> ();
		//rend.enabled = true;
		//rend.sharedMaterial = material [0];

	}
	void OnMouseDrag()
	{
		//Debug.Log ("Mouse drag");
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

		transform.position = objPosition;


	}
	void OnTriggerEnter(Collider other){
		
		if (other.CompareTag ("firething")) {
			other.GetComponentInChildren<ParticleSystem> ().startColor = new Color (0, 250, 0);
			//rend.sharedMaterial = material[1];
			this.gameObject.SetActive(false);
			Destroy(this.gameObject);
		}

	}


	// Update is called once per frame
	
}
