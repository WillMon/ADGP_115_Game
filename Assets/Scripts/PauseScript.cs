using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseScript : MonoBehaviour {

    public bool paused;
    public Text pauseText;

	// Use this for initialization
	void Start ()
    {
        paused = false;
	}
	
	// Update is called once per frame
	void Update ()

    {
	 if (Input.GetKeyDown(KeyCode.Space))
        {//Made a toggle
            paused = !paused;
        }
     if (paused == true)
        {
            pauseText.text = "PAUSE";
            Time.timeScale = 0;
        }
     else if (paused == false)
        {
            pauseText.text = "";
            Time.timeScale = 1;
        }
	}
}
