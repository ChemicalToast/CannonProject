using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{

    // Use this for initialization

    public GameObject projectile;
    public Transform spawnPoint;
    public float fireDelay;
    public float force;
    float rateOfFire = 0.5f;
    

    void Start()
    {

        projectile = Resources.Load("cannonBall") as GameObject;

    }


    void Update()
    {
        //Move
        CharacterController controller = GetComponent<CharacterController>();
        transform.Rotate(Input.GetAxis("Vertical") * 60 * Time.deltaTime, 0, Input.GetAxis("Horizontal") * 60 * Time.deltaTime);


        //Fire
        if (Input.GetButton("Fire1") && Time.time > fireDelay)
        {

            //Added delay so there wont be a cluster of projectiles at one tap
            fireDelay = Time.time + rateOfFire;

            GameObject clone = (GameObject)Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);

            Rigidbody rB = clone.GetComponent<Rigidbody>();

            rB.AddForce(spawnPoint.forward * force, ForceMode.Impulse);

    


        }
    }

}



