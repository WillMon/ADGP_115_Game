using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseScript : MonoBehaviour {
    
    //Create Variables
    public bool paused;
    public Text pauseText;
    public Canvas MainMenu;

	// Use this for initialization
	void Start ()
    {//Sets paused bool to false
        paused = false;
        //Enable 
        MainMenu = MainMenu.GetComponent<Canvas>();
        MainMenu.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()

    {//if space bar is pressed
	 if (Input.GetKeyDown(KeyCode.Space))
        {//Made a toggle
            //paused variable is now set to the opposite of what it was before the space bar was pressed
            paused = !paused;
            //print PAUSE to the screen
            pauseText.text = "     PAUSE";
        }
     //if paused is true..
     if (paused)
        {
            MainMenu.enabled = true;
            //Pause the game
            Time.timeScale = 0;
        }
     //If paused is set to false
     else if (!paused)
        {//Print nothing to the screen
            pauseText.text = "";
            //Set the game back to real time(unpaused)
            Time.timeScale = 1;
            //Disables the MainMenu button
            MainMenu.enabled = false;
        }
	}
}
