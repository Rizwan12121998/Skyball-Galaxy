using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class joystickSwitch : MonoBehaviour
{

    public GameObject leftctrl;
    public GameObject rightctrl;
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        Togglectrls();
    }

    public void Togglectrls()
    {
        if(flag == true)
        {
            
            leftctrl.SetActive(false);
            rightctrl.SetActive(true);
            flag = false;
        }
        else
        {
            leftctrl.SetActive(true);
            rightctrl.SetActive(false);
            flag = true;
        }
    }
}
