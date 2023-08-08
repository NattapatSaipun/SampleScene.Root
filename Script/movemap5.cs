using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemap5 : MonoBehaviour
{
    [SerializeField] GameObject p2; 
    [SerializeField] GameObject p2move; 
    [SerializeField] map5P2 run;
    [SerializeField] float speed = 4;
    
    [SerializeField] private CharacterController characterController;
   
   private void OnCollisionStay(Collision other) {
    if(other.gameObject.CompareTag("MoveMap5"))
    {
        
       //p2.transform.position = new Vector3(p2.transform.right*1) ;
       Vector3 move = transform.right * 1 + transform.forward * 0;
       characterController.Move(move*speed*Time.deltaTime);
       p2move.transform.rotation = Quaternion.Euler(0, 90, 0);
       run.isMove = true;
    }
    if(other.gameObject.CompareTag("MoveMap52"))
    {
        
       //p2.transform.position = new Vector3(p2.transform.right*1) ;
       Vector3 move = transform.right * -1 + transform.forward * 0;
       characterController.Move(move*speed*Time.deltaTime);
       p2move.transform.rotation = Quaternion.Euler(0, -90, 0);
       run.isMove = true;
    }if(other.gameObject.CompareTag("MoveMap53"))
    {
        
       //p2.transform.position = new Vector3(p2.transform.right*1) ;
       Vector3 move = transform.right * 0 + transform.forward * 1;
       characterController.Move(move*speed*Time.deltaTime);
       p2move.transform.rotation = Quaternion.Euler(0, 0, 0);
       run.isMove = true;
    }if(other.gameObject.CompareTag("MoveMap54"))
    {
        
       //p2.transform.position = new Vector3(p2.transform.right*1) ;
       Vector3 move = transform.right * 0 + transform.forward * -1;
       characterController.Move(move*speed*Time.deltaTime);
       p2move.transform.rotation = Quaternion.Euler(0, 180, 0);
       run.isMove = true;
    }
   }
   private void OnCollisionExit(Collision other) {
    run.isMove = false;
   }
}
