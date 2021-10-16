using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private static GameMaster instance;
    public Vector3 lastCheckPointPos;
    private int nextSceneToLoad;

      void Awake()
       {
           if(instance == null)
           {
               instance = this;
               DontDestroyOnLoad(instance);
           } else
           {
               Destroy(gameObject);
           }
       }  
  /* void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }

        else
        {
            instance.lastCheckPointPos = this.lastCheckPointPos;
            Destroy(gameObject);
        }
    }  */
}
