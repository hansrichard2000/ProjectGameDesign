using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllyCastle : MonoBehaviour
{
    public Text textbox;
    public float health = 100f;
    public float score;


    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "HP: " + health;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void minHealth(float dmg)
    {
        health -= dmg;
    }
}
