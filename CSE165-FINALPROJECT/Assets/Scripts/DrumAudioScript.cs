using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumAudioScript : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioClip clip;
    private AudioSource source;
    void Start()
    {
        source = transform.gameObject.GetComponent<AudioSource>();
        clip = source.clip;
        Debug.Log(source);
        Debug.Log(clip);
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger found");
        if (other.CompareTag("drumstick"))
        {   
            if (tag == "bass")
            {
                GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            }
            source.PlayOneShot(clip);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (tag == "bass")
        {
            GetComponent<Renderer>().material.SetColor("_Color", Color.white);
        }
    }


}
