using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class InGameMenus : MonoBehaviour {

    public Canvas quitMenu;
    public Canvas howtoMenu;


    // Use this for initialization
    void Start()
    {
        //Getting components allow the interaction to happen in the inspector between objects
        quitMenu = quitMenu.GetComponent<Canvas>();
        howtoMenu = howtoMenu.GetComponent<Canvas>();

        quitMenu.enabled = false;
        howtoMenu.enabled = false;
    }

    public void GoBack()
    {
        howtoMenu.enabled = false;

    }

    public void NoPress()
    {
        quitMenu.enabled = false;
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

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            
            howtoMenu.enabled = true;
        }
    }
}
