using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public GameObject GameProperties, Ufo;
    Data data;
    Ufo ufodata;
    float MermiFiyat = 5;
    void Start()
    {
        data = GameProperties.GetComponent<Data>();
        ufodata = Ufo.GetComponent<Ufo>();
    }

    public void Bullet()
    {
        if(data.Para >= MermiFiyat)
        {
            ufodata.Mermi += 5;
            data.Para -= MermiFiyat;
        }
    }
}
