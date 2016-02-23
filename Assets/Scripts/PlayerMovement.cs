using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    Animator anim;                   
    Vector3 movement;
    
    Vector3 playerMoves;            
    Rigidbody rbody;
    private float inputH;
    private float inputV;

    //int floorMask;                     
    float camRayLength = 100f;          

    void Start()
    {
        
        //floorMask = LayerMask.GetMask("Floor");
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
        
    }


    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal1");
        float v = Input.GetAxisRaw("Vertical1");

       
        Move(h, v);
        Turning();
        Animating();
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

    void Animating()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.Play("Move01_F");
        }

    }
}