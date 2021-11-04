using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameMaster gm;
    public AudioSource ticksource;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        ticksource = GetComponent<AudioSource>();
    }


   void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Position saved");
            gm.lastCheckPointPos = transform.position;
            Destroy(gameObject);
        }

        if (other.tag == "Target")
        {
            ticksource.Play();
        }
    }
}
