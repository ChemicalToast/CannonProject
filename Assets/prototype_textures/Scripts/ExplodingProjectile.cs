using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingProjectile : MonoBehaviour
{

    PlayerSwitch playerSwitch;
    MoveAndShoot moveAndShoot;

    // Use this for initialization
    void Start()
    {
        playerSwitch = FindObjectOfType<PlayerSwitch>();
        moveAndShoot = FindObjectOfType<MoveAndShoot>();

    }

    // Update is called once per frame
    void OnCollisionEnter()
    {
        GameObject prefab = Resources.Load("Explosion") as GameObject;

        GameObject explosion = Instantiate(prefab) as GameObject;

        explosion.transform.position = transform.position;

        Destroy(explosion, 5);

        Destroy(gameObject);

        playerSwitch.playerOneTurn = !playerSwitch.playerOneTurn;
       



    }
}
