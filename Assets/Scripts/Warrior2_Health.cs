﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior2_Health : MonoBehaviour
{
    public float health = 130f;
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
        }
    }
}
