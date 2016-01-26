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

    //Use this for initialization 
    void Start()
    {

    }


    //Called once per fram
    void Update()
    {
        //Stores the players name into this variable
        savep1 = PlayerPrefs.GetString("P1 Enter Name");
        //Stores the players name into this variable
        savep2 = PlayerPrefs.GetString("P2 Enter Name");

        //The Screen will display these strings
        saved.text = savep1;
        saved2.text = savep2;
    }

    //Fucntion called when wanting to save the names inputted by the player
    public void SaveNames()
    {
        //Take the new enterd strings and store them here
        p1Name = p1Text.text;
        p2Name = p2Text.text;

        //Sets the values to what was inputted
        PlayerPrefs.SetString("P1 Enter Name", p1Name);
        PlayerPrefs.SetString("P2 Enter Name", p2Name);
    }

}