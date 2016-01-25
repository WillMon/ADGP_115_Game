using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthScript : MonoBehaviour {


    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    

	// Use this for initialization
	void Start ()
    {
        currentHealth = startingHealth;
	}
	

    public void TakeDamage(int amount)
    {
        //Reduce Current Health By Amount Of Damage Taken
        currentHealth -= amount;

        //Set the health bar's value to the current health
        healthSlider.value = currentHealth;
    }

    //// Update is called once per frame
    void Update()
    {
        if(healthSlider.value == 0)
        {//Player Dies Here

        }
    }
}
