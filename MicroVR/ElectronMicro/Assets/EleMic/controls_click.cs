using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class controls_click : MonoBehaviour
{
    public Image opobj;
    public Image exobj;
    public Image meobj;
    public Image inobj;

    bool stat = false;

    Vector3 optrans;
    Vector3 extrans;
    Vector3 metrans;
    Vector3 infotrans;

    Vector3 ControlsStartPos;
    Vector3 ControlsSecondPos;

    Vector3 QuitStartPos;
    Vector3 QuitSecondPos;

    Vector3 MenuStartPos;
    Vector3 MenuSecondPos;

    Vector3 InfoStartPos;
    Vector3 InfoSecondPos;
    public void Start()
    {
        optrans = opobj.transform.position;
        extrans = exobj.transform.position;
        metrans = meobj.transform.position;
        infotrans = inobj.transform.position;

        ControlsStartPos = new Vector3(optrans.x, optrans.y, optrans.z);
        ControlsSecondPos = new Vector3(optrans.x, Screen.height/2, optrans.z);

        QuitStartPos = new Vector3(extrans.x, extrans.y, extrans.z);
        QuitSecondPos = new Vector3(optrans.x, Screen.height/2, extrans.z);

        MenuStartPos = new Vector3(metrans.x, metrans.y, metrans.z);
        MenuSecondPos = new Vector3(optrans.x, Screen.height/2, metrans.z);

        InfoStartPos = new Vector3(infotrans.x, infotrans.y, infotrans.z);
        InfoSecondPos = new Vector3(optrans.x, Screen.height/2, infotrans.z);
    }

    public void controlsButton()
    {
        if (stat == false)
        {
            opobj.GetComponent<Transform>().position = ControlsStartPos;
            stat = !stat;
        }
        else if(stat == true)
        {
            exobj.GetComponent<Transform>().position = QuitStartPos;
            meobj.GetComponent<Transform>().position = MenuStartPos;
            inobj.GetComponent<Transform>().position = InfoStartPos;

            opobj.GetComponent<Transform>().position = ControlsSecondPos;
            stat = !stat;
        }
    }
    public void exitButton()
    {
        if (stat == false)
        {
            exobj.GetComponent<Transform>().position = QuitStartPos;
            stat = !stat;
        }
        else if (stat == true)
        {
            opobj.GetComponent<Transform>().position = ControlsStartPos;
            meobj.GetComponent<Transform>().position = MenuStartPos;
            inobj.GetComponent<Transform>().position = InfoStartPos;

            exobj.GetComponent<Transform>().position = QuitSecondPos;
            stat = !stat;
        }
    }
    public void menuButton()
    {
        if (stat == false)
        {
            meobj.GetComponent<Transform>().position = MenuStartPos;
            stat = !stat;
        }
        else if (stat == true)
        {
            opobj.GetComponent<Transform>().position = ControlsStartPos;
            exobj.GetComponent<Transform>().position = QuitStartPos;
            inobj.GetComponent<Transform>().position = InfoStartPos;

            meobj.GetComponent<Transform>().position = MenuSecondPos;
            stat = !stat;
        }
    }
    public void infoButton()
    {
        if (stat == false)
        {
            inobj.GetComponent<Transform>().position = InfoStartPos;
            stat = !stat;
        }
        else if (stat == true)
        {
            opobj.GetComponent<Transform>().position = ControlsStartPos;
            exobj.GetComponent<Transform>().position = QuitStartPos;
            meobj.GetComponent<Transform>().position = MenuStartPos;

            inobj.GetComponent<Transform>().position = InfoSecondPos;
            stat = !stat;
        }
    }
}
