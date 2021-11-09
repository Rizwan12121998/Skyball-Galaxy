using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    public GameObject deathExplosion;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Instantiate(deathExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
