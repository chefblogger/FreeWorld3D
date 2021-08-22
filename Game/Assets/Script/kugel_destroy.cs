using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kugel_destroy : MonoBehaviour
{


private void OnCollisionEnter(Collision collision)
    {
       if (collision.transform.tag == "target")
        {

            //Debug.Log("Getroffen");
            
            //Destroy(collision.gameObject);

            gameObject.SetActive(false);


            //particleExplosion.Play();
            //explosionAudio.Play();

            scoreboard.points += 1;
        }

               if (collision.transform.tag == "wand")
        {

            
            gameObject.SetActive(false);

        }
    }


}
