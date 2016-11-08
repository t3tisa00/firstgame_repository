using UnityEngine;
using System.Collections;

public class FireCollision : MonoBehaviour {

    //public Color colorCopperSulphate = new Color(0, 250, 0);
    public GameObject smokeon;
    

    void Start()
    {
        //audio = GameObject.Find("Audio").GetComponent<AudioSource>();
        //audio.Stop();
        //audio.Play ();
    }

    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("water"))
        {
            smokeon.SetActive(true);
            //smokeAudio.SetActive(true);
            //audio.Play();
            this.gameObject.SetActive(false);
            other.gameObject.SetActive(false);
        }

        else if (other.CompareTag("firething"))
        {
            this.gameObject.GetComponentInChildren<ParticleSystem>().startColor = new Color(0, 250, 0);
            other.gameObject.SetActive(false);
        }

    }
}
