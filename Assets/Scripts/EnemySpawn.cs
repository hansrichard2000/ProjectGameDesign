using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemy;
    public float positionX, positionY;
    int level = 1;
    int enemyDeadCounter = 0;

    public AllyCastle allyCastle;
    public EnemySpawn enemySpawn;

    // Start is called before the first frame update
    void Start()
    {
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
            //print("enemy 1 spawn");
            newEnemy.GetComponent<Knight1_Health>().levelSpawn = this.enemySpawn;
        } else if (random == 1)
        {
            //print("enemy 2 spawn");
            newEnemy.GetComponent<Knight2_Health>().levelSpawn = this.enemySpawn;
        } else if (random == 2)
        {
            //print("enemy 3 spawn");
            newEnemy.GetComponent<Knight3_Health>().levelSpawn = this.enemySpawn;
        }
        
        newEnemy.transform.position = new Vector3(positionX, positionY, 0);
    }

    public void EnemyDead()
    {
        enemyDeadCounter += 1;

        if (enemyDeadCounter == level)
        {
            level++;
            StartLevel();
        }

    }
}
