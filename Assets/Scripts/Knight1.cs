using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Knight1 : MonoBehaviour
{
    public Animator animator;
    public EnemyMovement enemyMovement;
    //buat ambil attribute dia sendiri
    public GameObject knight1;

    public float damage = 20;

    //buat ngurangi attribut nyawa lawannya
    public GameObject warrior1;
    public GameObject warrior2;
    public GameObject warrior3;

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
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ally")
        {


            if (collision.collider.name == "Warrior_01__IDLE_000(Clone)")
            {

                //kalau nabrak warrior 1, langsungngeaatck
                AttackTimer(collision);

            }
            else if (this.name == "Warrior_02__IDLE_000(Clone)")
            {
                //collision.collider.GetComponent<Warrior2>().health -= damage;

            }
            else if (this.name == "Warrior_03__IDLE_000(Clone)")
            {
                //collision.collider.GetComponent<Warrior3>().health -= damage;

            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ally")
        {
            Attack();
            StopMoving();
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
    }

    void StopMoving()
    {
        enemyMovement.GetComponent<EnemyMovement>().speed = 0;
    }

    void AttackTimer(Collision2D collision)
    {
        //cuma bisa attack kalau status attacknya false
        if (attack_status == false)
        {
            //attack trus status attacknya di true
            collision.collider.GetComponent<Warrior1_Health>().health -= damage;
            attack_status = true;

        }

        //DEBUG MAI BEIBEHHH
        //print("collision :" + collision.collider.GetComponent<Warrior1_Health>().health);
        //print("sec : " + seconds);
        //print("time : " + timer);
    }
}
