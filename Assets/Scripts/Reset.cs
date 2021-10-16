using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*
public class Reset : MonoBehaviour
{
    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel(scene.name);
        }
        else
        {

        }
    }
}
*/
public class Reset : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            print("Entering the " + other.gameObject.name);
    }


    private void OnTriggerstay(Collider other)
    {
        if (other.tag == "Player")
            print("In the " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            print("Exiting the " + other.gameObject.name);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}