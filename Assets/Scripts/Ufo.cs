using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ufo : MonoBehaviour
{
    public float HaraketHizi,MermiHizi,AtisHizi,Mermi;
    private float AtisHiziSayac;
    public GameObject Roket;
    public GameObject RocketSpawnPos;
    public GameObject GameProperties;
    Data data;
    public AudioSource FireSound;
    public Text MermiUI;
    void Start()
    {
        data = GameProperties.GetComponent<Data>();
    }

    void Update()
    {
       Move();
       Fire();
    }
    
    void Move()
    {
        float Key;
        Key = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, Key * HaraketHizi * Time.deltaTime, 0);
    }

    void Fire()
    {
        MermiUI.text = Mermi.ToString();
        if (Input.GetKeyUp(KeyCode.C) && AtisHiziSayac <= Time.time && Mermi > 0)
        {
            AtisHiziSayac = Time.time + AtisHizi;
            FireSound.Play();
            GameObject nesne = Instantiate(Roket, RocketSpawnPos.transform.position, transform.rotation);
            Rigidbody2D rb;
            rb = nesne.GetComponent<Rigidbody2D>();
            nesne.transform.rotation = new Quaternion(Roket.transform.rotation.x, Roket.transform.rotation.y, Roket.transform.rotation.z, Roket.transform.rotation.w);
            rb.AddForce(transform.right * MermiHizi * Time.deltaTime);
            Mermi--;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Debug.Log("Oyun Bitti Koçum");
        }

        if(col.gameObject.tag == "Coin")
        {
            data.Para += col.GetComponent<Coin>().para;
            Destroy(col.gameObject);
        }
    }
}
