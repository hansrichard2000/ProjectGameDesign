﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior3 : MonoBehaviour
{
    public Animator animator;
    public AllyMovement allyMovement;
    //buat ambil attribute dia sendiri
    public GameObject warrior3;

    public Transform AttackPoint;
    public float AttackRange;
    public LayerMask enemyLayers;

    public float damage = 5;

    //buat ngurangi attribut nyawa lawannya
    public GameObject knight1;
    public GameObject knight2;
    public GameObject knight3;

    //buat timer
    public float timer = 0f;
    public int seconds;
    public bool attack_status = false; //status apakah orangnya lagi ngeattack atau nggak

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // seconds in float
        timer += Time.deltaTime;
        // turn seconds in float to int
        seconds = (int)(timer % 60);

        //ngecek kalau waktunya lebih dari 1 detik
        if (seconds >= 1)
        {
            //set back time to 0 second
            seconds = 0;
            timer = 0f;

            attack_status = false;
        }

        //Cek lawan
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRange, enemyLayers);

        if (hitEnemies.Length > 0)
        {
            StopMoving();
            //print("masih ada lawan");
        }
        else
        {
            Walk();
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {


            if (collision.collider.name == "Knight_01__IDLE_000(Clone)")
            {

                //kalau nabrak warrior 1, langsungngeaatck
                AttackTimer(collision);

            }
            else if (collision.collider.name == "Knight_02__IDLE_000(Clone)")
            {
                //collision.collider.GetComponent<Warrior2>().health -= damage;
                AttackTimer(collision);

            }
            else if (collision.collider.name == "Knight_03__IDLE_000(Clone)")
            {
                //collision.collider.GetComponent<Warrior3>().health -= damage;
                AttackTimer(collision);

            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.collider.name);
        if (collision.collider.tag == "Enemy")
        {
            Attack();
            //StopMoving();

            //allyCastle.minHealth(7);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
    }

    //untuk ngecek range dari physics 2d di atas
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }
    void Walk()
    {
        animator.ResetTrigger("Attack");
        animator.SetFloat("Speed", 0.03f);
        allyMovement.GetComponent<AllyMovement>().speed = 0.03f;
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
    }

    void StopMoving()
    {
        animator.SetFloat("Speed", 0f);
        allyMovement.GetComponent<AllyMovement>().speed = 0;
    }

    void AttackTimer(Collision2D collision)
    {
        //cuma bisa attack kalau status attacknya false
        if (attack_status == false)
        {
            if (collision.collider.name == "Knight_01__IDLE_000(Clone)")
            {
                //attack trus status attacknya di true
                collision.collider.GetComponent<Knight1_Health>().health -= damage;

            }
            else if (collision.collider.name == "Knight_02__IDLE_000(Clone)")
            {
                //attack trus status attacknya di true
                collision.collider.GetComponent<Knight2_Health>().health -= damage;

            }
            else if (collision.collider.name == "Knight_03__IDLE_000(Clone)")
            {
                //attack trus status attacknya di true
                collision.collider.GetComponent<Knight3_Health>().health -= damage;

            }
            attack_status = true;

        }

        //DEBUG MAI BEIBEHHH
        //print("collision :" + collision.collider.GetComponent<Warrior3_Health>().health);
        //print("sec : " + seconds);
        //print("time : " + timer);
    }
}
