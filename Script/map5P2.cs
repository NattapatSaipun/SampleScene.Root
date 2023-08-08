using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map5P2 : MonoBehaviour
{
     [SerializeField] private CharacterController characterController;
    [SerializeField] private float speed = 6f;
    [SerializeField] private float jumpHight = 3f;

    [SerializeField] private float gravity = -9.81f;
    
    Vector3 velocity;

    [SerializeField] Transform checkGround;
   
    [SerializeField] LayerMask groundMask;
    [SerializeField] private bool isGround;
    [SerializeField] public bool isMove;
    public Animator Anime;
    Vector3 lastPos;
    public GameObject _rotate;
     public AudioSource jump;

    //public AudioSource walk;
       private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    private void Start() {
        Anime = GetComponent<Animator>();
    }
     private void Update()
    {
       


        //PlayerGravity
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity*Time.deltaTime);

        //GroundCheck
        isGround = Physics.CheckSphere(checkGround.position, 0.25f, groundMask);
        

        //jump
        if(Input.GetButtonDown("Jump3") && characterController.isGrounded )
        {
            velocity.y = Mathf.Sqrt(jumpHight * -0.65f * gravity);
            jump.Play();
        }

        //Player fall from Height
        if(isGround && velocity.y < 0)
        {
            velocity.y = -3f;
        }

        // if(transform.position != lastPos)
        // {
        //     isMove = true;
            
        // }
        // else
        // {
        //     isMove = false;
        //    // walk.Stop();
        // }
 
     lastPos = transform.position;

     AnimePlayer();
 
    }
    private void AnimePlayer()
    {
        Anime.SetBool("isMoving", isMove);
        Anime.SetBool("isGround", isGround);
    }
}
