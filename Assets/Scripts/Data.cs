using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Data : MonoBehaviour
{
    public float kill;
    public Text KillText;
    public float Para;
    public Text ParaText;
    public float DusmanEngel;
    public float Sure;
    float SureSayac;
    public Text SureText;
    void Update()
    {
        KillText.text = kill.ToString();
        ParaText.text = Para.ToString();
        SureText.text = Sure.ToString();
        if(DusmanEngel <= 0)
        {
            SceneManager.LoadScene("GameOver");      
        }

        SureSayac += Time.deltaTime;
        if (SureSayac >= 1)
        {
            Sure++;
            SureSayac = 0;
        }
        
    }
}
