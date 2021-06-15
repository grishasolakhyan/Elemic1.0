using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class element_click : MonoBehaviour
{
    public Material Mat;
    int sib;
    int oib;
    int nab;
    int cab;
    int feb;
    int alb;
    int cb;
    int mgb;
    int clb;
    int aub;

    void OnApplicationQuit()
    {
        Mat.SetInt("_IntSi", 0);
        Mat.SetInt("_IntO", 0);
        Mat.SetInt("_IntNa", 0);
        Mat.SetInt("_IntCa", 0);
        Mat.SetInt("_IntFe", 0);
        Mat.SetInt("_IntAl", 0);
        Mat.SetInt("_IntC", 0);
        Mat.SetInt("_IntMg", 0);
        Mat.SetInt("_IntCl", 0);
        Mat.SetInt("_IntAu", 0);
    }

    public void Si()
    {
        if (sib == 1)
        {
            Mat.SetInt("_IntSi", sib);
            sib = 0;
        }
        else if (sib == 0)
        {
            Mat.SetInt("_IntSi", sib);
            sib = 1;
        }
    }
    public void O()
    {
        if (oib == 0)
        {
            Mat.SetInt("_IntO", oib);
            oib = 1;
        }
        else if (oib == 1)
        {
            Mat.SetInt("_IntO", oib);
            oib = 0;
        }
    }
    public void Na()
    {
        if (nab == 0)
        {
            Mat.SetInt("_IntNa", nab);
            nab = 1;
        }
        else if (nab == 1)
        {
            Mat.SetInt("_IntNa", nab);
            nab = 0;
        }
    }
    public void Ca()
    {
        if (cab == 0)
        {
            Mat.SetInt("_IntCa", cab);
            cab = 1;
        }
        else if (cab == 1)
        {
            Mat.SetInt("_IntCa", cab);
            cab = 0;
        }
    }
    public void Fe()
    {
        if (feb == 0)
        {
            Mat.SetInt("_IntFe", feb);
            feb = 1;
        }
        else if (feb == 1)
        {
            Mat.SetInt("_IntFe", feb);
            feb = 0;
        }
    }
    public void Al()
    {
        if (alb == 0)
        {
            Mat.SetInt("_IntAl", alb);
            alb = 1;
        }
        else if (alb == 1)
        {
            Mat.SetInt("_IntAl", alb);
            alb = 0;
        }
    }
    public void C()
    {
        if (cb == 0)
        {
            Mat.SetInt("_IntC", cb);
            cb = 1;
        }
        else if (cb == 1)
        {
            Mat.SetInt("_IntC", cb);
            cb = 0;
        }
    }
    public void Mg()
    {
        if (mgb == 0)
        {
            Mat.SetInt("_IntMg", mgb);
            mgb = 1;
        }
        else if (mgb == 1)
        {
            Mat.SetInt("_IntMg", mgb);
            mgb = 0;
        }
    }
    public void Cl()
    {
        if (clb == 0)
        {
            Mat.SetInt("_IntCl", clb);
            clb = 1;
        }
        else if (clb == 1)
        {
            Mat.SetInt("_IntCl", clb);
            clb = 0;
        }
    }
    public void Au()
    {
        if (aub == 0)
        {
            Mat.SetInt("_IntAu", aub);
            aub = 1;
        }
        else if (aub == 1)
        {
            Mat.SetInt("_IntAu", aub);
            aub = 0;
        }
    }
}
