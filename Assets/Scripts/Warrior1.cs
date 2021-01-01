using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior1 : MonoBehaviour
{

    public Animator animator;
    public AllyMovement allyMovement;
    public GameObject warrior1;

    public float damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.collider.name);
        if (collision.collider.tag == "Enemy")
        {
            Attack();
            StopMoving();
            //allyCastle.minHealth(7);
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
    }

    void StopMoving()
    {
        allyMovement.GetComponent<AllyMovement>().speed = 0;
    }

}
