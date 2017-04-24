using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {



    public Camera camera1;
    public Camera camera2;
    private ShootingScript shootScript;
    // Use this for initialization
    void Start ()
    {
        shootScript = FindObjectOfType<ShootingScript>();
        camera1.enabled = true;
        camera2.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (shootScript.hasFired)
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
            shootScript.hasFired = false;
        }
    }
}
