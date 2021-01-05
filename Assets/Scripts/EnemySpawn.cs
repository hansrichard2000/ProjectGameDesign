using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemy;
    public float positionX, positionY;
    int level = 1;
    int stage = 1;
    int enemyDeadCounter = 0;

    public Text levelStage;

    public AllyCastle allyCastle;
    public EnemySpawn enemySpawn;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("MyScore", 0);
        StartLevel();
    }

    void StartLevel()
    {
        //generate alien sebanyak levelnya
        for (var i = 0; i < level; i++)
        {
            SpawnEnemy();
        }
        enemyDeadCounter = 0;
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SpawnEnemy();
        }
    }*/

    void SpawnEnemy()
    {
        positionX = Random.Range(30.5f, 34.5f);
        positionY = -3f;
        //positionY = Random.Range(-2.75f, -3.75f);
        int random = Random.Range(0, enemy.Length);

        var newEnemy = Instantiate(enemy[random]);
        newEnemy.GetComponent<EnemyDeath>().allyCastle = this.allyCastle;
        newEnemy.GetComponent<EnemyDeath>().levelSpawn = this.enemySpawn;
        if (random == 0)
        {
            newEnemy.GetComponent<Knight1_Health>().levelSpawn = this.enemySpawn;

            //buat tambah nyawa per stage
            if ( stage == 2)
            {
                newEnemy.GetComponent<Knight1_Health>().health += newEnemy.GetComponent<Knight1_Health>().health * 0.1f;
            } else if (stage == 3)
            {
                newEnemy.GetComponent<Knight1_Health>().health += newEnemy.GetComponent<Knight1_Health>().health * 0.2f;
            }

        } else if (random == 1)
        {
            newEnemy.GetComponent<Knight2_Health>().levelSpawn = this.enemySpawn;

            //buat tambah nyawa per stage
            if (stage == 2)
            {
                newEnemy.GetComponent<Knight2_Health>().health += newEnemy.GetComponent<Knight2_Health>().health * 0.1f;
            }
            else if (stage == 3)
            {
                newEnemy.GetComponent<Knight2_Health>().health += newEnemy.GetComponent<Knight2_Health>().health * 0.2f;
            }

        } else if (random == 2)
        {
            newEnemy.GetComponent<Knight3_Health>().levelSpawn = this.enemySpawn;

            //buat tambah nyawa per stage
            if (stage == 2)
            {
                newEnemy.GetComponent<Knight3_Health>().health += newEnemy.GetComponent<Knight3_Health>().health * 0.1f;
            }
            else if (stage == 3)
            {
                newEnemy.GetComponent<Knight3_Health>().health += newEnemy.GetComponent<Knight3_Health>().health * 0.2f;
            }

        }
        
        newEnemy.transform.position = new Vector3(positionX, positionY, 0);
    }

    public void EnemyDead()
    {
        enemyDeadCounter += 1;

        if (enemyDeadCounter == level)
        {
            stage++;

            if(stage > 3)
            {
                stage = 1;
                level++;
            }

            levelStage.text = "Level " + level + "-" + stage;
            StartLevel();
        }

    }
}
