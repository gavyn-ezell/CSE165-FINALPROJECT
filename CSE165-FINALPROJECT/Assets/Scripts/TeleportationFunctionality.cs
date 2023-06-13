using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationFunctionality : MonoBehaviour
{
    GameObject playerRig;
    GameObject teleportationObject;
    LineRenderer teleportationIndicator;
    public OVRHand leftHand;

    bool lineOn;
    // Start is called before the first frame update
    void Start()
    {
        playerRig = GameObject.Find("OVRCameraRig");
        teleportationObject = GameObject.Find("TeleportationLine");
        teleportationIndicator = teleportationObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lineOn)
        {
            teleportationIndicator.SetPosition(0, transform.position);
            teleportationIndicator.SetPosition(1, leftHand.PointerPose.position);
        }
        else {
            
        }
    }

    public void teleportPlayer()
    {
        playerRig.transform.position = transform.position;
    }

    public void showLine()
    {   
        lineOn = true;
        teleportationObject.SetActive(true);
    }

    public void disableLine()
    {
        lineOn = false;
        teleportationObject.SetActive(false);
    }
}
