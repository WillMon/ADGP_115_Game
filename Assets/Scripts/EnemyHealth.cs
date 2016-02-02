using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
    public int startingHealth = 100;
    public int currentHealth;
    EnemyMovement enemyMove;
    //Animator anim;
    bool isDead;
	// Use this for initialization
	void Start () {

        currentHealth = startingHealth;
        enemyMove = GetComponent<EnemyMovement>();
        //anim = GetComponent<Animator>();
}

    public void TakeDamage(int damage)
    {

        if (isDead)
        {// ... no need to take damage so exit the function
            return;
        }

        // Reduce the current health by the amount of damage sustained.
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Dead();
        }
    }
    void Dead() { 

        isDead = true;


        //anim.SetTrigger("Die");

        enemyMove.enabled = false;

        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    
        Destroy(gameObject, 2f);
    }
   // Update is called once per frame
    void Update () {
	    
	}
}
