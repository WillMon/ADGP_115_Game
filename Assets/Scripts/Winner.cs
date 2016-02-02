using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Winner : MonoBehaviour
{

    public Canvas PlayAgain;

    HealthScript player;

    public GameObject p1;
    public GameObject p2;
    public Text winningText;

    // Use this for initialization
    void Start()
    {
        PlayAgain.GetComponent<Canvas>();

        PlayAgain.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (p1.gameObject.GetComponent<HealthScript>().currentHealth <= 0 && p2.gameObject.GetComponent<HealthScript>().currentHealth > 0)
        {
            winningText.text = "Player 2 Wins!";
            PlayAgain.enabled = true;
        }
        else if (p2.gameObject.GetComponent<HealthScript>().currentHealth <= 0 && p1.gameObject.GetComponent<HealthScript>().currentHealth > 0)
        {
            winningText.text = "Player 1 Wins!";
            PlayAgain.enabled = true;
        }
    }

    public void ClickYes()
    {
        Application.LoadLevel(2);
    }

    public void ClickNo()
    {
        Application.Quit();

    }

}
