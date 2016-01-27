using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

    public float timeBetweenAttacks = 0.5f;
    public int attackDmg = 10;

    GameObject player1;
    GameObject player2;
    HealthScript playerScript;
    EnemyHealth enemyScript;
    //Animator anim;

    bool playerInRange;
    float time;
    

	// Use this for initialization
	void Start () {

        player1 = GameObject.FindGameObjectWithTag("Player");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        playerScript = GetComponent<HealthScript>();
        enemyScript = GetComponent<EnemyHealth>();
        //anim = GetComponent<Animator>();
           

	}
	
    void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject == player1)
        {
            playerInRange = false;
        }
        if(collision.gameObject == player2)
        {
            playerInRange = false;
        }
    }
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time >= timeBetweenAttacks && playerInRange && enemyScript.currentHealth > 0)
        {
            Attack();
        }

        if(playerScript.currentHealth <= 0)
        {
            //anim.SetTrigger(playerDead);
        }
	}
    void Attack()
    {
        time = 0f;

        if(playerScript.currentHealth > 0)
        {
            playerScript.TakeDamage(attackDmg);
        }
    }
}
