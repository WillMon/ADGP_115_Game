using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InputScript : MonoBehaviour
{
    //Variables
    private string p1Name;
    private string p2Name;

    //Public text to access
    public Text p1Text;
    public Text p2Text;

    //Store the inputted names
    public Text saved;
    public Text saved2;

    //Saves the names to put into game later
    private string savep1;
    private string savep2;


    void Start()
    {

    }



    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    //Exit.quitMenu.enabled = true;
        //    Application.Quit();
        //}
        savep1 = PlayerPrefs.GetString("P1 Enter Name");
        savep2 = PlayerPrefs.GetString("P2 Enter Name");


        saved.text = savep1;
        saved2.text = savep2;
    }

    public void SaveNames()
    {
        p1Name = p1Text.text;
        p2Name = p2Text.text;

        PlayerPrefs.SetString("P1 Enter Name", p1Name);
        PlayerPrefs.SetString("P2 Enter Name", p2Name);
    }

}