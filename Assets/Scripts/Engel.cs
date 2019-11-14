using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel : MonoBehaviour
{
    public GameObject GameProperties;
    Data data;
    void Start()
    {
        data = GameProperties.GetComponent<Data>();
    }

    void Update()
    {
        
    }

   void OnTriggerEnter2D(Collider2D col)
   {    
       if(col.gameObject.tag == "Enemy")
       {
            data.DusmanEngel -= 1;
       } 
   }
}
