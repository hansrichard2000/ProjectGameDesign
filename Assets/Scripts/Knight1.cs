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

    public Transform AttackPoint;
    public float AttackRange;
    public LayerMask enemyLayers;

    public float damage = 8;

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

        //Cek lawan
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRange, enemyLayers);

        if (hitEnemies.Length > 0)
        {
            //Attack();
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
        if (collision.collider.tag == "Ally")
        {


            if (collision.collider.name == "Warrior_01__IDLE_000(Clone)")
            {

                //kalau nabrak warrior 1, langsungngeaatck
                AttackTimer(collision);

            }
            else if (collision.collider.name == "Warrior_02__IDLE_000(Clone)")
            {
                //collision.collider.GetComponent<Warrior2>().health -= damage;
                AttackTimer(collision);

            }
            else if (collision.collider.name == "Warrior_03__IDLE_000(Clone)")
            {
                //collision.collider.GetComponent<Warrior3>().health -= damage;
                AttackTimer(collision);

            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ally")
        {
            Attack();
            //StopMoving();
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
        enemyMovement.GetComponent<EnemyMovement>().speed = 0.03f;
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
    }

    void StopMoving()
    {
        animator.SetFloat("Speed", 0f);
        enemyMovement.GetComponent<EnemyMovement>().speed = 0;
    }

    void AttackTimer(Collision2D collision)
    {
        //cuma bisa attack kalau status attacknya false
        if (attack_status == false)
        {
            if (collision.collider.name == "Warrior_01__IDLE_000(Clone)")
            {
                //attack trus status attacknya di true
                collision.collider.GetComponent<Warrior1_Health>().health -= damage;

            }
            else if (collision.collider.name == "Warrior_02__IDLE_000(Clone)")
            {
                //attack trus status attacknya di true
                collision.collider.GetComponent<Warrior2_Health>().health -= damage;

            }
            else if (collision.collider.name == "Warrior_03__IDLE_000(Clone)")
            {
                //attack trus status attacknya di true
                collision.collider.GetComponent<Warrior3_Health>().health -= damage;

            }
            attack_status = true;

        }

        //DEBUG MAI BEIBEHHH
        //print("collision :" + collision.collider.GetComponent<Warrior1_Health>().health);
        //print("sec : " + seconds);
        //print("time : " + timer);
    }
}
