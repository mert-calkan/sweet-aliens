using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roket : MonoBehaviour
{
    public GameObject GameProperties;
    Data data;
    void Start()
    {
        GameProperties = GameObject.FindGameObjectWithTag("Properties");
        data = GameProperties.GetComponent<Data>();
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Enemy")
        {
            GameObject patlama = Instantiate(col.GetComponent<Enemy>().PatlamaEfekt, col.transform.position, transform.rotation);
            patlama.transform.rotation = new Quaternion(patlama.transform.rotation.x, patlama.transform.rotation.y,90, patlama.transform.rotation.w);
            data.kill += 1;
            Destroy(this.gameObject);
            Destroy(col.gameObject);
            data.Para += 1;
        }
    }
}
