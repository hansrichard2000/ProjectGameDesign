using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyCastle : MonoBehaviour
{
    
    public float health = 100f;
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void minHealth(float dmg)
    {
        health -= dmg;
    }
}
