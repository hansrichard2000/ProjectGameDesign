using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{

    public AllyCastle allyCastle;

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "AllyCastle")
        {
            Destroy(this.gameObject);
        }
    }*/

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "AllyCastle")
        {
            Destroy(this.gameObject);
        }
    }*/

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "AllyCastle")
        {
            Destroy(this.gameObject);
            allyCastle.minHealth(7);
        }
    }
}
