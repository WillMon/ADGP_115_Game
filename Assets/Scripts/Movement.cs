using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    //Speed variable used for how fast to move object
    public float speed = 15.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if this key is pressed..
	 if(Input.GetKey(KeyCode.D))
        {//Create a vector object and set it to a new vector
            Vector3 right = new Vector3(1.0f, 0.0f, 0.0f);
            //Move the objects position with these parameters
            transform.Translate(right * speed * Time.deltaTime);
        }
        //if this key is pressed..
        if (Input.GetKey(KeyCode.A))
        {//Create a vector object and set it to a new vector
            Vector3 left = new Vector3(-1.0f, 0.0f, 0.0f);
            //Move the objects position with these parameters
            transform.Translate(left * speed * Time.deltaTime);
        }
        //if this key is pressed..
        if (Input.GetKey(KeyCode.W))
        {//Create a vector object and set it to a new vector
            Vector3 up = new Vector3(0.0f, 0.0f, 1.0f);
            //Move the objects position with these parameters
            transform.Translate(up * speed * Time.deltaTime);
        }
        //if this key is pressed..
        if (Input.GetKey(KeyCode.S))
        {//Create a vector object and set it to a new vector
            Vector3 down = new Vector3(0.0f, 0.0f, -1.0f);
            //Move the objects position with these parameters
            transform.Translate(down * speed * Time.deltaTime);
        }
       
    }
}
