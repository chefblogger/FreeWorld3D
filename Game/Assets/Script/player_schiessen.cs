using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_schiessen : MonoBehaviour
{


    public float bulletSpeed = 10000.0f;
    public float bulletSelfdestruct = 3.0f;
    public GameObject bullet;

    //AudioSource bulletAudio;

    // Use this for initialization
    void Start()
    {

        //bulletAudio = GetComponent<AudioSource>();

    }

    void Fire()
    {
        //Shoot
        GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidBodyBullet = tempBullet.GetComponent<Rigidbody>();
        tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * bulletSpeed);
        Destroy(tempBullet, bulletSelfdestruct); //0.5f

        scoreboard.shootscore += 1;

        //Play Audio
        //bulletAudio.Play();

    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        //if (Input.GetKey(KeyCode.Space))
        {
            Fire();
        }
        /*
        if( UltimateJoystick.GetTapCount( "schiessen" ) )
        {
            Fire();
        }
        */

    }

    /*
    //handy button
    private void OnGUI()
    {
        GUI.skin.button.fontSize = 30;
        //GUI.Button(new Rect(0, 0, 600, 100), "Menu");
       if (GUI.Button (new Rect (Screen.width - 200,Screen.height - 100,200,100), "Fire")) {
           Fire();
       }
    }
    */
}
