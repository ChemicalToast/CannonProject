using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{


    GameObject projectile;
    private CameraSwitch camScript;
    private PlayerSwitch playerSwitch;
    public Transform spawnPoint;
    public float fireDelay;
    public float force;
    public bool hasFired = false;
    float rateOfFire = 0.5f;

    void Start()
    {

        projectile = Resources.Load("cannonBall") as GameObject;
        camScript = FindObjectOfType<CameraSwitch>();
        playerSwitch = FindObjectOfType<PlayerSwitch>();


    }


    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > fireDelay)
        {

            //Added delay so there wont be a cluster of projectiles at one tap
            fireDelay = Time.time + rateOfFire;
            GameObject clone = (GameObject)Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
            Rigidbody rB = clone.GetComponent<Rigidbody>();
            rB.AddForce(spawnPoint.forward * force, ForceMode.Impulse);
            hasFired = true;
            playerSwitch.playerOneTurn = !playerSwitch.playerOneTurn;


        }
    }
}
