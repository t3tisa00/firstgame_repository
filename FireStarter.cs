using UnityEngine;
using System.Collections;

public class FireStarter : MonoBehaviour {

    public GameObject fire;
    private bool mixtureCheck = false;


    // Update is called once per frame
    void OnTriggerEnter (Collider other) {

        if (other.CompareTag("mixingTable"))
        {
            mixtureCheck = true;
        }

        if (other.gameObject.name == "Water" && mixtureCheck == true)
        {
            fire.SetActive(true);
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
	
	}

    void OnTriggerExit (Collider other)
    {
        if (other.CompareTag("mixingTable"))
        {
            mixtureCheck = false;
        }
    }


}
