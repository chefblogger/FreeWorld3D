using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreboard : MonoBehaviour
{
    
public static int score = 0;
public static int shootscore = 0;
public static int points = 0;

    private void OnGUI()
    {
        GUI.skin.box.fontSize = 20;
        GUI.Box(new Rect(0, 0, 200, 40), "Coins:" + score);
        GUI.Box(new Rect(205, 0, 200, 40), "Schüsse: " + shootscore);
        GUI.Box(new Rect(410, 0, 200, 40), "Punkte: " + points);
        if (score >= 20){
            //Debug.Log("Gewonnen");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        
    }


}
