using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthScript : MonoBehaviour {


    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;

    //Animator anim;
    PlayerMovement PlayerMove;
    

    bool isDead;
    bool TakesDmg;

	// Use this for initialization
	void Start ()
    {
        //anim = GetComponent<Animator>();
        PlayerMove = GetComponent<PlayerMovement>();


        currentHealth = startingHealth;
	}
	

    public void TakeDamage(int amount)
    {
        //Reduce Current Health By Amount Of Damage Taken
        currentHealth -= amount;

        //Set the health bar's value to the current health
        healthSlider.value = currentHealth;

        
        if (healthSlider.value == 0)
        {
            Dead();
        }
    }
    void Dead()
    {
        isDead = true;

        //anim.SetTrigger("Die");

        PlayerMove.enabled = false;
    }
    //// Update is called once per frame
    void Update()
    {
      
    }
}
