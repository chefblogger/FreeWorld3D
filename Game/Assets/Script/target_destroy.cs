using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_destroy : MonoBehaviour
{



private void OnCollisionEnter(Collision collision)
    {
       if (collision.transform.tag == "bullet")
        {

            //Debug.Log("Getroffen");
            
            //Destroy(collision.gameObject);

            gameObject.SetActive(false);


            //particleExplosion.Play();
            //explosionAudio.Play();

            //scoreboard.points += 1;
        }

              
    }



}
