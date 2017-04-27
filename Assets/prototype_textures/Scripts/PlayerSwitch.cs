using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour {



    public Camera cam1;
    public Camera cam2;
    public GameObject player1;
    public GameObject player2;
    public bool playerOneTurn = true;

	// Use this for initialization
	void Start ()
    {
        cam1.enabled = true;
        cam2.enabled = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
        //Player 1's turn
        if (playerOneTurn)
        {
            player1.GetComponent<MoveAndShoot>().enabled = true;
            player2.GetComponent<MoveAndShoot>().enabled = false;
            cam1.enabled = true;
            cam2.enabled = false;
        }
        //Player 2's turn
        if (!playerOneTurn)
        {
            player1.GetComponent<MoveAndShoot>().enabled = false;
            player2.GetComponent<MoveAndShoot>().enabled = true;
            cam2.enabled = true;
            cam1.enabled = false;
        }
	}
}
