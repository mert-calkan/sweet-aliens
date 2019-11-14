using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayRemove : MonoBehaviour
{
    public float Sure;

    void Update()
    {
        StartCoroutine(Sil());
    }

    IEnumerator Sil()
    {
        yield return new WaitForSeconds(Sure); 
        Destroy(this.gameObject);
    }
}
