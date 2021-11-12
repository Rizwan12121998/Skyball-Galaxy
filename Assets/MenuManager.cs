using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject optionCanvas;
    [SerializeField] GameObject menuCanavas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateOptionCanvas(bool val)
    {
        optionCanvas.SetActive(val);
        menuCanavas.SetActive(!val);
    }
}
