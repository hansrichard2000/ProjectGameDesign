using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyDeath : MonoBehaviour
{

    public EnemyCastle enemyCastle;
    private void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "EnemyCastle")
        {
            Destroy(this.gameObject);

        }
    }
}
