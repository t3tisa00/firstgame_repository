using UnityEngine;
using System.Collections;

public class pickingobject : MonoBehaviour
{
    public GameObject Thumb;
    private Vector3 offset;
    private bool val = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {


        /*void OnTriggerEnter(Collider other)
        {
            //Debug.Log("Collided with: " + other.tag);
            if (other.CompareTag("element") || other.CompareTag("water") || other.CompareTag("firething"))
            {
                val = true;
            }
        }
        void OnTriggerStay(Collider other)
        { 
            if (val == true)
            {*/
        if (Thumb.GetComponent<thumbchecker>().ThumbCollided())
        {

            //void onTriggerEnter( Collider other){
            //if (other.CompareTag("element") || other.CompareTag("water") || other.CompareTag("firething"))
            //{

            //offset = transform.position - other.gameObject.transform.position;
            //other.gameObject.transform.position = transform.position + offset;
            //Debug.Log(other.gameObject.name);

            other.gameObject.transform.position = this.transform.position;

            //}
        }

        //}

        //}
        /*void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("element") || other.CompareTag("water") || other.CompareTag("firething"))
            {
                 val = false;
            }
        }*/
    }
}