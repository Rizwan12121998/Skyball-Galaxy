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

    public void OnTriggerEnter(Collider collision)
    {
        gm.lastCheckPointPos = GameObject.FindGameObjectWithTag("StartPoint").transform.position; 
        SceneManager.LoadScene(LevelName);

        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levelIsUnlocked"))
        {
            PlayerPrefs.SetInt("levelIsUnlocked", currentLevel + 1);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelIsUnlocked") + " UNLOCKED");
    }
}
