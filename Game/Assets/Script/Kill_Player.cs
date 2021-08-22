using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_Player : MonoBehaviour
{

private int Lebenspunkte = 0;


private void OnCollisionEnter(Collision collision)
     {
        if (collision.transform.tag == "Player")
        {


        //neue lebenspunkte
            Lebenspunkte = PlayerPrefs.GetInt("lifepoint") - 1;   
            PlayerPrefs.SetInt("lifepoint", Lebenspunkte);

        if (Lebenspunkte <= 0)
            {
            //load death szene
            SceneManager.LoadScene("StartDeath"); 
            }
            else
            {
                //level muss neu gestartet werden
               //SceneManager.LoadScene("StartLevelDeath");  
            }


        }
     }





}
