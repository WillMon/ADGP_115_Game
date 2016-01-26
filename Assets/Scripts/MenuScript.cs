using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

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
        quitMenu.enabled = false;
        howtoMenu.enabled = false;

    }
	

    public void ExitPress()
    {//Allows the quit menu to be displayed
        quitMenu.enabled = true;
        //Displays the buttons
        playText.enabled = false;
        exitText.enabled = false;
        howtoText.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        playText.enabled = true;
        exitText.enabled = true;
        howtoText.enabled = true;
    }

    public void GoBack()
    {
        howtoMenu.enabled = false;

        playText.enabled = true;
        exitText.enabled = true;
        howtoText.enabled = true;
    }

    public void HowToPress()
    {
        howtoMenu.enabled = true;
    }

    //When You Click The Play Button
    public void StartGame()
    {
        Application.LoadLevel(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Allows the quit menu to be displayed
            quitMenu.enabled = true;

        }
    }
}
