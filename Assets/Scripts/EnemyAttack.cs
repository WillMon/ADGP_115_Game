using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{

    public float timeBetweenAttacks = 0.5f;
    public int attackDmg = 10;

    GameObject player1;
    GameObject player2;
    GameObject Wall1;
    GameObject Wall2;

    WallHealth armorScript;
    HealthScript playerScript;
    EnemyHealth enemyScript;

    //Animator anim;

    bool playerInRange1;
    bool playerInRange2;
    bool WallInRange1;
    bool WallInRange2;
    float time;


    // Use this for initialization
    void Start()
    {

        player1 = GameObject.FindGameObjectWithTag("Player");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        Wall1 = GameObject.FindGameObjectWithTag("Wall1");
        Wall2 = GameObject.FindGameObjectWithTag("Wall2");
        playerScript = gameObject.GetComponent<HealthScript>();
        enemyScript = gameObject.GetComponent<EnemyHealth>();
        armorScript = gameObject.GetComponent<WallHealth>();
        //anim = GetComponent<Animator>()

    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject == player1)
        {
            playerInRange1 = false;
        }
        if (collision.gameObject == player2)
        {
            playerInRange2 = false;
        }
        if (collision.gameObject == Wall1)
        {
            WallInRange1 = false;
        }
        if (collision.gameObject == Wall2)
        {
            WallInRange2 = false;
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == player1)
        {
            playerInRange1 = true;
        }
        if (collision.gameObject == player2)
        {
            playerInRange2 = true;
        }
        if (collision.gameObject == Wall1)
        {
            WallInRange1 = true;
        }
        if (collision.gameObject == Wall2)
        {
            WallInRange2 = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if ((time >= timeBetweenAttacks) && playerInRange1 && enemyScript.currentHealth > 0)
        {
            time = 0f;
            if (player1.GetComponent<HealthScript>().currentHealth > 0)
            {
                //playerScript.TakeDamage(attackDmg);
                player1.GetComponent<HealthScript>().TakeDamage(attackDmg);
            }
        }

        if ((time >= timeBetweenAttacks) && playerInRange2 && enemyScript.currentHealth > 0)
        {
            time = 0f;
            if (player2.GetComponent<HealthScript>().currentHealth > 0)
            {
                //playerScript.TakeDamage(attackDmg);
                player2.GetComponent<HealthScript>().TakeDamage(attackDmg);
            }
        }


        if ((time >= timeBetweenAttacks) && WallInRange1 && enemyScript.currentHealth > 0)
        {
            time = 0f;
            if (Wall1.GetComponent<WallHealth>().currentHP > 0)
            {
                //playerScript.TakeDamage(attackDmg);
                Wall1.GetComponent<WallHealth>().TakeDmg(attackDmg);
            }
        }

        if ((time >= timeBetweenAttacks) && WallInRange2 && enemyScript.currentHealth > 0)
        {
            time = 0f;
            if (Wall2.GetComponent<WallHealth>().currentHP > 0)
            {
                //playerScript.TakeDamage(attackDmg);
                Wall2.GetComponent<WallHealth>().TakeDmg(attackDmg);
            }
        }


        //if (playerScript.currentHealth <= 0)
        //{

        //    //anim.SetTrigger(playerDead);
        //}
    }
}

    //public void Attack()
    //{
    //    //Debug.Log("Enemy attacked");

    //    time = 0f;

    //    if(player1.GetComponent<HealthScript>().currentHealth > 0)
    //    {
    //        //playerScript.TakeDamage(attackDmg);
    //        player1.GetComponent<HealthScript>().TakeDamage(attackDmg);
    //    }

    //    if(armorScript.currentHP > 0)
    //    {
    //        armorScript.TakeDmg(attackDmg);
    //    }
    //}

