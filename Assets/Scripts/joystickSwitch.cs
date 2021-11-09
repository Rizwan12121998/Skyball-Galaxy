using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class joystickSwitch : MonoBehaviour
{

    public GameObject leftctrl;
    public GameObject rightctrl;
    public GameObject leftbutton;
    public GameObject rightbutton;
    bool flag = false;
    public BallMotor ballMotor;
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

            leftbutton.SetActive(true);
            rightbutton.SetActive(false);

            flag = false;
            ballMotor.Switchjoystick();
        }
        else
        {
            leftctrl.SetActive(true);
            rightctrl.SetActive(false);

            leftbutton.SetActive(false);
            rightbutton.SetActive(true);


            flag = true;
            ballMotor.Switchjoystick();
        }
    }
}
