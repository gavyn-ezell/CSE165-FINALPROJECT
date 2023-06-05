using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumstickPairSpawner : MonoBehaviour
    {
        public GameObject d1;
        public GameObject d2;


        Vector3 startPos1;
        Vector3 startPos2;
        Quaternion startQuat;


        public void Start()
        {
            startPos1 = d1.transform.position;
            startPos2 = d2.transform.position;
            startQuat = d1.transform.rotation;
        }

        
        public void resetSticks()
        {
            d1.GetComponent<Rigidbody>().velocity = new Vector3(0.0f,0.0f,0.0f);
            d2.GetComponent<Rigidbody>().velocity = new Vector3(0.0f,0.0f,0.0f);
            d1.transform.position = startPos1;
            d2.transform.position = startPos2;
            
            d1.transform.rotation = startQuat;
            d2.transform.rotation = startQuat;
        }
    }

