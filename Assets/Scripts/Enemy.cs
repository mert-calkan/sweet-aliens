using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    public float Hiz;
    public GameObject PatlamaEfekt;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(-transform.right * Hiz * Time.deltaTime);
    }
}
