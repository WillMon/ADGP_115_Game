using UnityEngine;
using System.Collections;

public class PlayerMovement2 : MonoBehaviour {
    public float speed = 6f;
    Rigidbody rbody;
    Vector3 movement;
    //Animator anim;
    int floorMask;
    float camRayLength = 100f;

	// Use this for initialization
	void Start () {
        //anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxisRaw("Horizontal2");
        float v = Input.GetAxisRaw("Vertical2");
        Move(h, v);
        //Turning();
        //Animating(h, v);
    }

    void Move(float h, float v)
    {

        movement.Set(h, 0f, v);


        movement = movement.normalized * speed * Time.deltaTime;

        rbody.MovePosition(transform.position + movement);
    }

    void Turning()
    {

        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;

        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {

            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            rbody.MoveRotation(newRotation);
        }
    }

    //    void Animating(float h, float v)
    //    {
    //        bool walking = h != 0f || v != 0f;
    //        anim.SetBool("IsWalking", walking);
    //    }
}
