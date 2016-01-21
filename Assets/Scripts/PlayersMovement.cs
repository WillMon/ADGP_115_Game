using UnityEngine;
using System.Collections;

public class PlayersMovement : MonoBehaviour {

    public Animator anim;
    public Rigidbody rbody;

    private float InputH;
    private float InputV;
	// At run time 
	void Start () {
        
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

        InputH = Input.GetAxis("Horizantal");
        InputV = Input.GetAxis("Vertical");



        anim.SetFloat("InputH", InputH);
        anim.SetFloat("InputV", InputV);

        float MoveX = InputH * 20f * Time.deltaTime;
        float MoveZ = InputV * 50f * Time.deltaTime;

        rbody.velocity = new Vector3(MoveX, 0f, MoveZ);
	}
}
