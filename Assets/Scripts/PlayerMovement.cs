using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;            
    Vector3 movement;
    //Animator anim;          
    Vector3 playerMoves;            
    Rigidbody rbody;          
    //int floorMask;                     
    float camRayLength = 100f;          

    void Start()
    {
        
        //floorMask = LayerMask.GetMask("Floor");
        //anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal1");
        float v = Input.GetAxisRaw("Vertical1");

       
        Move(h, v);
        Turning();
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
  

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    Quaternion TurnsAround = transform.rotation;
        //    TurnsAround.y = 90f;
        //    transform.rotation = TurnsAround;

            
        
    }

//    void Animating(float h, float v)
//    {
//        bool walking = h != 0f || v != 0f;
//        anim.SetBool("IsWalking", walking);
//    }
}