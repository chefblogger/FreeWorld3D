using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_portal : MonoBehaviour
{

    
    public GameObject PortalEnd;
    public float AnzCoin = 3;
    private bool isOn;
    

    // Start is called before the first frame update
    void Start()
    {
        //PortalEnd.SetActive(false);
        PortalEnd.SetActive(false);
        isOn = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (scoreboard.score == AnzCoin)
        {
            
            if (isOn == false)
            {
               isOn = true;
               PortalEnd.SetActive(true);
            }

        }

/*        
      if (isOn == false)
        {
            //Debug.Log("Portal ist zu");
            isOn = false;
        }

    if (scoreboard.score == AnzCoin)
        {
            //Debug.Log("öffnen");
            
             if (isOn == false)
                {
                //Debug.Log("######");
                   Instantiate(PortalEnd, new Vector3(PosiX, PosiY, PosiZ), Quaternion.identity);
                   isOn = true; 
                }






        }


/*
      if (isOn == true)
      {
          OpenPortal();
          isOn = true;
      }

            void OpenPortal(){
            Instantiate(PortalEnd, new Vector3(-20, 2, -3), Quaternion.identity); 
            }
*/

    }





}
