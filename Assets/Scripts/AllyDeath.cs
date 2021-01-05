using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyDeath : MonoBehaviour
{

    public float health, damage;
    public EnemyCastle enemyCastle;
    private void Start()
    {

        if (this.name == "Warrior_01__IDLE_000(Clone)")
        {
            health = 3;
            damage = 1;
        }
        else if (this.name == "Warrior_02__IDLE_000(Clone)")
        {
            health = 2;
            damage = 2;

        }
        else if (this.name == "Warrior_03__IDLE_000(Clone)")
        {
            health = 1;
            damage = 3;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "EnemyCastle")
        {
            Destroy(this.gameObject);

        }
    }
}
