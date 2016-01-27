using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

public class WelcomeScript : MonoBehaviour {

    //Public variables created
    public Canvas welcomeMenu;
    public Button playButton;

    // Use this for initialization
    void Start ()
    {
        //Sets menus to the proper components
        welcomeMenu = welcomeMenu.GetComponent<Canvas>();
        playButton = playButton.GetComponent<Button>();
        //Sets the play button to false
        playButton.enabled = false;

    }

    //When input is changed call this function
    public void InputChanged()
    {//Enables the play button
        playButton.enabled = true;
            
    }

    //When you Click Play
    public void StartGame()
    {//Loads the next scene
      Application.LoadLevel(2);

    }

}
