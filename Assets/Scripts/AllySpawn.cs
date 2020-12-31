using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllySpawn : MonoBehaviour
{
    public GameObject[] ally;
    public float positionX, positionY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnAlly();
        }
    }

    void SpawnAlly()
    {
        positionX = Random.Range(-2.5f, -1.5f);
        positionY = Random.Range(-2.75f, -3.75f);

        var newAlly = Instantiate(ally[Random.Range(0, ally.Length)]);
        newAlly.transform.position = new Vector3(positionX, positionY, 0);
    }
}
