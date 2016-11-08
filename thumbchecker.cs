using UnityEngine;
using System.Collections;

public class thumbchecker : MonoBehaviour {
   
    private bool val;

    public bool ThumbCollided()
    {
        return val;
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Collided with: " + other.tag);
        if (other.CompareTag("element") || other.CompareTag("water") || other.CompareTag("firething"))
        {
            val = true;
        }
    }
   
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("element") || other.CompareTag("water") || other.CompareTag("firething"))
        {
            val = false;
        }
    }
}
