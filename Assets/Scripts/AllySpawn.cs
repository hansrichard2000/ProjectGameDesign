using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllySpawn : MonoBehaviour
{
    public GameObject[] ally;
    public float positionX, positionY;
    public ScoringSystem ScoringSystem;

    private int priceWarrior1 = 50;
    private int priceWarrior2 = 75;
    private int priceWarrior3 = 100;

    //public EnemyCastle enemyCastle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnAlly();
        }*/

        
    }

    void SpawnAlly(int id)
    {
        positionX = Random.Range(-2.5f, -1.5f);
        positionY = -3f;
        //positionY = Random.Range(-3.45f, -3.55f);

        var newAlly = Instantiate(ally[id]);
        //newAlly.GetComponent<AllyDeath>().enemyCastle = this.enemyCastle;
        newAlly.transform.position = new Vector3(positionX, positionY, 0);
    }

    public void SpawnWarrior1()
    {
        if (ScoringSystem.score > priceWarrior1)
        {
            ScoringSystem.score -= priceWarrior1;
            ScoringSystem.ScoreChange();
            SpawnAlly(0);
        }
    }

    public void SpawnWarrior2()
    {
        if (ScoringSystem.score > priceWarrior2)
        {
            ScoringSystem.score -= priceWarrior2;
            ScoringSystem.ScoreChange();
            SpawnAlly(1);
        }
    }

    public void SpawnWarrior3()
    {
        if (ScoringSystem.score > priceWarrior3)
        {
            ScoringSystem.score -= priceWarrior3;
            ScoringSystem.ScoreChange();
            SpawnAlly(2);
        }
    }
}
