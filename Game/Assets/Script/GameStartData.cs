using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //wieviele leben hat der user?
        PlayerPrefs.SetInt("lifepoint", 3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
