using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WallHealth : MonoBehaviour {
    // Starting Wall health 
    public int startingHealth = 100;
    public int currentHP;
    public Slider armorSlider;
    public GameObject Wall;
	// Use this for initialization
    
	void Start () {
        currentHP = startingHealth;
        Wall = gameObject;
	}
	public void TakeDmg(int amount)
    {
        // Damage taken from current health
        currentHP -= amount;
        // replicates the current health on to the slider
        armorSlider.value = currentHP;
    }
	// Update is called once per frame
	void Update () {
        if (armorSlider.value <= 0)
        {
            Destroy(Wall);
        }
	}
}
