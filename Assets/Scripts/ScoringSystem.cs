using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public Text scoreValue;
    public int score = 250;
    //buat timer
    public float timer = 0f;
    public int seconds;
    public bool attack_status = false; //status apakah orangnya lagi ngeattack atau nggak

    // Start is called before the first frame update
    void Start()
    {
        scoreValue.text = "Score: " + score; 
    }

    // Update is called once per frame
    void Update()
    {
        // seconds in float
        timer += Time.deltaTime;
        // turn seconds in float to int
        seconds = (int)(timer % 60);

        if (seconds >= 2)
        {
            seconds = 0;
            timer = 0;
            score += 15;
            ScoreChange();
        }

    }
    public void ScoreChange()
    {
        scoreValue.text = "Score: " + score;
    }

}
