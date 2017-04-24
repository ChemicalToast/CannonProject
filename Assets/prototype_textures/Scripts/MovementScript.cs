using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    // Use this for initialization



	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {

        transform.Rotate(Input.GetAxis("Vertical") * 60 * Time.deltaTime, 0, Input.GetAxis("Horizontal") * 60 * Time.deltaTime);
        CharacterController controller = GetComponent<CharacterController>();
    }
}
