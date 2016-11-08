using UnityEngine;
using System.Collections;

public class Smokeactivate : MonoBehaviour {
	float distance =10;
	public GameObject smokeon;
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
		smokeon.SetActive (true);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
