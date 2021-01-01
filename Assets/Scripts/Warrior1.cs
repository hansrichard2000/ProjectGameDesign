using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior1 : MonoBehaviour
{

    public Animator animator;

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
            //allyCastle.minHealth(7);
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
    }
}
