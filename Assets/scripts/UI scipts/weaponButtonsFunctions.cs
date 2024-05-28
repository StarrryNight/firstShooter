using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponButtonsFunctions : MonoBehaviour
{
    public GameObject panel;

    //public good_move script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void circleSelect()
    {
        good_move.weaponNum = 0;
    }

    public void rocketSelect()
    {
        good_move.weaponNum = 1;
    }

    public void panelExit()
    {
        panel.SetActive(false);
    }
}
