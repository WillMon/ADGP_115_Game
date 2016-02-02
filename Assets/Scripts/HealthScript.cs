using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthScript : MonoBehaviour {

    //Creates public variables
    public int startingHealth = 100;
    public int currentHealth;
    //Allows access to Slider object
    public Slider healthSlider;
    public GameObject player;
    

	// Use this for initialization
	void Start ()
    {//sets currentHealth to startingHealth
        currentHealth = startingHealth;
        player = gameObject;
	}
	
    //Function called when something has taken damage
    public void TakeDamage(int amount)
    {
        //Reduce Current Health By Amount Of Damage Taken
        currentHealth -= amount;

        //Set the health bar's value to the current health
        healthSlider.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {//if the healthSlider has a value of 0...
        if (healthSlider.value <= 0)
        {
            Destroy(player);
        }
    }
}
