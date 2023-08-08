using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private float speed = 6f;
    [SerializeField] private float jumpHight = 3f;

    [SerializeField] private float gravity = -9.81f;
    
    Vector3 velocity;

    [SerializeField] Transform checkGround;
   
    [SerializeField] LayerMask groundMask;
    [SerializeField] private bool isGround;
    [SerializeField] private bool isMove;
    public Animator Anime;
    Vector3 lastPos;
    public GameObject _rotate;

    public AudioSource jump;
   

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    private void Start() {
        Anime = GetComponent<Animator>();
    }

    private void Update()
    {
        //Movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        characterController.Move(move*speed*Time.deltaTime);

        if(Input.GetAxis("Horizontal")!=0)
        {
          
        }
         
        if(Input.GetAxis("Horizontal") < 0)
        {
          
          _rotate.transform.rotation = Quaternion.Euler(0, -90, 0);
            

        }
         if(Input.GetAxis("Horizontal") > 0)
        {
           
          _rotate.transform.rotation = Quaternion.Euler(0, 90, 0);


        }
         if(Input.GetAxis("Vertical") > 0)
        {
           
          _rotate.transform.rotation = Quaternion.Euler(0, 0, 0);


        }
        if(Input.GetAxis("Vertical") < 0)
        {
          
          _rotate.transform.rotation = Quaternion.Euler(0, 180, 0);


        }

        //PlayerGravity
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity*Time.deltaTime);

        //GroundCheck
        isGround = Physics.CheckSphere(checkGround.position, 0.25f, groundMask);
        

        //jump
        if(Input.GetButtonDown("Jump2") && characterController.isGrounded )
        {
            velocity.y = Mathf.Sqrt(jumpHight * -0.65f * gravity);
            jump.Play();
        }

        //Player fall from Height
        if(isGround && velocity.y < 0)
        {
            velocity.y = -3f;
        }

        if(transform.position != lastPos)
        {
            isMove = true;
            
        }
        else
        {
            isMove = false;
           
        }
 
     lastPos = transform.position;

     AnimePlayer();
 
    }
    private void AnimePlayer()
    {
        Anime.SetBool("isMoving", isMove);
        Anime.SetBool("isGround", isGround);
    }
   

 
}
