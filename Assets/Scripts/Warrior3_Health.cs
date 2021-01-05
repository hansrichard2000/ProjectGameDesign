using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior3_Health : MonoBehaviour
{
    public float health = 90f;
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
