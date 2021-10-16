using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    //private int nextSceneToLoad;
    public string LevelName;
    private GameMaster gm;
    //private static NextLevel instance;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }


    /*  void Awake()
      {
          if (instance == null)
          {
              instance = this;
              DontDestroyOnLoad(instance);
          }
          else
          {
              Destroy(gameObject);
          }
      }
      */

    private void OnTriggerEnter(Collider collision)
    {
        gm.lastCheckPointPos = GameObject.FindGameObjectWithTag("StartPoint").transform.position; 
        SceneManager.LoadScene(LevelName);
    }
}
