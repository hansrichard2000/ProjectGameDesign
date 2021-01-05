using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text myscore;
    public Text highscore;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("MyScore") > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("MyScore"));
        }

        highscore.text = "Highscore : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        myscore.text = "Score : " + PlayerPrefs.GetInt("MyScore", 0).ToString();
    }

}
