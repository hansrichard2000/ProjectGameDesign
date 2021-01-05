using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{

    public float damage;

    public AllyCastle allyCastle;

    public EnemySpawn levelSpawn;

    private void Start()
    {

        if (this.name == "Knight_01__IDLE_000(Clone)")
        {
            damage = 1;
        }
        else if (this.name == "Knight_02__IDLE_000(Clone)")
        {
            damage = 2;

        }
        else if (this.name == "Knight_03__IDLE_000(Clone)")
        {
            damage = 3;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "AllyCastle")
        {
            Destroy(this.gameObject);
            allyCastle.minHealth(damage);
            levelSpawn.EnemyDead();
        }
    }
}
