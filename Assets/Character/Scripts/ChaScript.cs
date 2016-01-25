using UnityEngine;
using System.Collections;

public class ChaScript : MonoBehaviour
{
    private Animator anim;
    public Rigidbody rbody;

    private float InputH;
    private float InputV;
    void Start()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            print("pressed UP");
            anim.SetBool("Run",true);
            transform.position += Vector3.forward * Time.deltaTime;
        }
        else
        {
            anim.SetBool("Run", false);
            transform.position += Vector3.zero * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("RunLeft", true);
            transform.position += Vector3.left * Time.deltaTime;
        }
        else
        {
            anim.SetBool("RunLeft", false);
            transform.position += Vector3.zero * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("RunRight", true);
            transform.position += Vector3.right * Time.deltaTime;
        }
        else
        {
            anim.SetBool("RunRight", false);
            transform.position += Vector3.zero * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("RunBack", true);
            transform.position += Vector3.back * Time.deltaTime;
        }
        else
        {
            anim.SetBool("RunBack", false);
            transform.position += Vector3.zero * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Attack", true);
        }
        else
        {
            anim.SetBool("Attack", false);
        }

        InputH = Input.GetAxis("Horizantal");
        InputV = Input.GetAxis("Vertical");



        anim.SetFloat("InputH", InputH);
        anim.SetFloat("InputV", InputV);

        float MoveX = InputH * 20f * Time.deltaTime;
        float MoveZ = InputV * 50f * Time.deltaTime;

        rbody.velocity = new Vector3(MoveX, 0f, MoveZ);
    }
}
