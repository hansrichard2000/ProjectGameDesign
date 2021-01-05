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
        positionX = Random.Range(20.5f, 21.5f);
        positionY = -3f;
        //positionY = Random.Range(-2.75f, -3.75f);

        var newEnemy = Instantiate(enemy[Random.Range(0, enemy.Length)]);
        newEnemy.GetComponent<EnemyDeath>().allyCastle = this.allyCastle;
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
