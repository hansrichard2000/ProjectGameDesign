using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{

    public float health, damage;

    public AllyCastle allyCastle;

    private void Start()
    {

        if (this.name == "Knight_01__IDLE_000(Clone)")
        {
            health = 3;
            damage = 1;
        }
        else if (this.name == "Knight_02__IDLE_000(Clone)")
        {
            health = 2;
            damage = 2;

        }
        else if (this.name == "Knight_03__IDLE_000(Clone)")
        {
            health = 1;
            damage = 3;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "AllyCastle")
        {
            Destroy(this.gameObject);
            allyCastle.minHealth(damage);
        }
    }
}
