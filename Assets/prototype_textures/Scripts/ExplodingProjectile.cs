using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingProjectile : MonoBehaviour
{

    
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter()
    {
        GameObject prefab = Resources.Load("Explosion") as GameObject;
        GameObject explosion = Instantiate(prefab) as GameObject;
        explosion.transform.position = transform.position;

        Destroy(explosion, 5);
        Destroy(gameObject);
        

    }
}
