using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AllyCastle : MonoBehaviour
{
    public Text hpValue;
    public float health = 100f;
    public float score;

    public EnemySpawn levelSpawn;
    public Sprite castle50;

    // Start is called before the first frame update
    void Start()
    {
        //hpValue.text = "HP: " + health;
    }

    // Update is called once per frame
    void Update()
    {

        //hpValue.text = "HP: " + health;
        if (health <= 50)
        {
            this.GetComponent<SpriteRenderer>().sprite = castle50;
        }
    }

    public void minHealth(float dmg)
    {
        health -= dmg;

        hpValue.text = "HP: " + health;

        //hancurin kastil kalau nyawa habis
        if (health <= 0)
        {
            Destroy(this.gameObject);
            GameOver();
        }
    
    }
    

    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
