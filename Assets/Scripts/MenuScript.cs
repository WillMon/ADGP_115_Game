using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

    //Public Variables
    public Canvas quitMenu;
    public Canvas howtoMenu;
    public Button playText;
    public Button exitText;
    public Button howtoText;
    

	// Use this for initialization
	void Start ()
    {
        //Getting components allow the interaction to happen in the inspector between objects
        quitMenu = quitMenu.GetComponent<Canvas>();
        howtoMenu = howtoMenu.GetComponent<Canvas>();

        playText = playText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        howtoText = howtoText.GetComponent<Button>();

        //Set the menus to false
        quitMenu.enabled = false;
        howtoMenu.enabled = false;

    }
	
    //Function called when pressing exit button
    public void ExitPress()
    {//Allows the quit menu to be displayed
        quitMenu.enabled = true;
        //Displays the buttons
        playText.enabled = false;
        exitText.enabled = false;
        howtoText.enabled = false;
    }

    //Function called when pressing no button
    public void NoPress()
    {
        //Disbales the quitMenu 
        quitMenu.enabled = false;
        //Enables all the following buttons
        playText.enabled = true;
        exitText.enabled = true;
        howtoText.enabled = true;
    }

    //Function called when pressing the back button
    public void GoBack()
    {//Disbales this menu
        howtoMenu.enabled = false;
        //Enables these buttons
        playText.enabled = true;
        exitText.enabled = true;
        howtoText.enabled = true;
    }

    //Function called when the HowTo button is pressed
    public void HowToPress()
    {//Enables the howtoMenu
        howtoMenu.enabled = true;
    }

    //When You Click The Play Button
    public void StartGame()
    {//Loads the next scene
        Application.LoadLevel(1);
    }

    //When the Exit button is pressed
    public void ExitGame()
    {//Quit the game
        Application.Quit();
    }


}
