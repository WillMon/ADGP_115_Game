using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

public class WelcomeScript : MonoBehaviour {

    public Canvas welcomeMenu;
    public Button playButton;

    // Use this for initialization
    void Start ()
    {
        
        welcomeMenu = welcomeMenu.GetComponent<Canvas>();
        playButton = playButton.GetComponent<Button>();
        playButton.enabled = false;

    }

    
    public void InputChanged()
    {
        playButton.enabled = true;
            
    }

    //When you Click Play
    public void StartGame()
    {
      Application.LoadLevel(2);

    }

}
