using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text Score;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("MyScore") > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("MyScore"));
        }

        //Kalau mau bersihin high score
        //PlayerPrefs.SetInt("HighScore", 0);

        Score.text = "Score : " + PlayerPrefs.GetInt("MyScore", 0).ToString() + " | Highscore : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

}
