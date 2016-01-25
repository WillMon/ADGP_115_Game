using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {


    public float speed = 15.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	 if(Input.GetKey(KeyCode.D))
        {
            Vector3 right = new Vector3(1.0f, 0.0f, 0.0f);
            transform.Translate(right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 left = new Vector3(-1.0f, 0.0f, 0.0f);
            transform.Translate(left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 up = new Vector3(0.0f, 0.0f, 1.0f);
            transform.Translate(up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 down = new Vector3(0.0f, 0.0f, -1.0f);
            transform.Translate(down * speed * Time.deltaTime);
        }
       
    }
}
