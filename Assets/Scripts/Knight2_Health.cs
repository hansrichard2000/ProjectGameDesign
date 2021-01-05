﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight2_Health : MonoBehaviour
{
    public EnemySpawn levelSpawn;
    public float health = 75f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            Destroy(this.gameObject);
            levelSpawn.EnemyDead();
        }
    }
}
