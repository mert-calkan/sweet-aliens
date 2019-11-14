using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public float SpawnSuresi,CoinSpawnSuresi;
    private float SpawnSuresiSayac,CoinSpawnSayac;
    public GameObject Enemy, Coin,SpawnNoktasi1, SpawnNoktasi2, SpawnNoktasi3, SpawnNoktasi4;
    void Start()
    {
     
    }

    void Update()
    {
        if(SpawnSuresiSayac <= Time.time)
        {
            SpawnSuresiSayac = Time.time + SpawnSuresi;
            int sira;
            sira = Random.Range(1, 5);
            if (sira == 1)
            {
                Instantiate(Enemy, SpawnNoktasi1.transform.position, transform.rotation);
            }
            else if (sira == 2)
            {
                Instantiate(Enemy, SpawnNoktasi2.transform.position, transform.rotation);
            }
            else if (sira == 3)
            {
                Instantiate(Enemy, SpawnNoktasi3.transform.position, transform.rotation);
            }
            else if (sira == 4)
            {
                Instantiate(Enemy, SpawnNoktasi4.transform.position, transform.rotation);
            }
        }   
        
        if(CoinSpawnSayac <= CoinSpawnSuresi)
        {
            CoinSpawnSayac += Time.deltaTime;
        }
        if(CoinSpawnSayac >= CoinSpawnSuresi)
        {
            int sira;
            sira = Random.Range(1, 5);
            if (sira == 1)
            {
                Instantiate(Coin, SpawnNoktasi1.transform.position, transform.rotation);
            }
            else if (sira == 2)
            {
                Instantiate(Coin, SpawnNoktasi2.transform.position, transform.rotation);
            }
            else if (sira == 3)
            {
                Instantiate(Coin, SpawnNoktasi3.transform.position, transform.rotation);
            }
            else if (sira == 4)
            {
                Instantiate(Coin, SpawnNoktasi4.transform.position, transform.rotation);
            }
            CoinSpawnSayac = 0;
        }
    }
}
