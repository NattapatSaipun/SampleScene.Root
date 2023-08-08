using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractP2 : MonoBehaviour
{
    public bool hasInteract2 = false;
     public bool haswarp2 = false;
     public bool laser = false;
     public bool end = false;

   private void OnCollisionEnter(Collision other) {
    if(other.gameObject.CompareTag("Player2"))
    {
        
        hasInteract2 = true;
    }
     if(other.gameObject.CompareTag("boxR"))
    {
        Destroy(other.gameObject);
    }
    if(other.gameObject.CompareTag("endgame"))
    {
        
        end = true;
    }

   }
   private void OnCollisionExit(Collision other) {
     if(other.gameObject.CompareTag("Player2"))
    {
       
        hasInteract2 = false;
    }
    
   
   }
   private void OnTriggerEnter(Collider other) {
    if(other.gameObject.CompareTag("finishpoint"))
    {
        
        haswarp2 = true;
    }
     if(other.gameObject.CompareTag("biglaser"))
    {
        
        laser = true;
    }
   }
   private void OnTriggerExit(Collider other) {
     if(other.gameObject.CompareTag("finishpoint"))
    {
        
        haswarp2 = false;
    }
   }
}
