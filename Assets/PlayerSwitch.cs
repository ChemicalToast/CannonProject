using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour {


    public GameObject playerOne;
    public GameObject playerTwo;
    public bool playerOneTurn = false;

	// Use this for initialization
	void Start ()
    {
        


    }
	
	// Update is called once per frame
	void Update ()
    {
        if (playerOneTurn)
        {
            playerOne.GetComponent<MovementScript>().enabled = false;
            playerOne.GetComponent<ShootingScript>().enabled = false;
            playerTwo.GetComponent<MovementScript>().enabled = true;
            playerTwo.GetComponent<ShootingScript>().enabled = true;

        }
        if (!playerOneTurn)
        {
            playerOne.GetComponent<MovementScript>().enabled = true;
            playerOne.GetComponent<ShootingScript>().enabled = true;
            playerTwo.GetComponent<MovementScript>().enabled = false;
            playerTwo.GetComponent<ShootingScript>().enabled = false;
        }
	}
}
