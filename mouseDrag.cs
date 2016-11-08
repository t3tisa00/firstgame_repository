using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mouseDrag : MonoBehaviour {
	
	public Text ResultText;
	// Use this for initialization
	float distance = 10;
	public GameObject fireoff;

	void start(){
		ResultText.text = "";
	}

	void OnMouseDrag()
	{
		//Debug.Log ("Mouse drag");
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

		transform.position = objPosition;


	}
	void OnTriggerEnter(Collider other){
		if (other.CompareTag("element")) {
			ResultText.text = "fire is formed ";
			//DestroyObject (other);

			Destroy (gameObject);
			//gameObject.fireoff.SetActive (false);

			fireoff.SetActive (true);

		}

	}
}
