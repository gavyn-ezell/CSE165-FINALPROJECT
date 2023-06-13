using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCameraScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cam;
    public Transform p1;
    public Transform p2;

    float startTime;
    void Start()
    {
        // IEnumerator coroutine = zoomOut();
        // StartCoroutine()
        startTime = Time.time;
    }

    void Update()
    {
        float timediff = Time.time - startTime;
        cam.transform.position = Vector3.Lerp(p1.position, p2.position, timediff / 10.0f);
    }


}
