using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public bool hasInteract = false;
    public bool haswarp = false;
    public bool laser = false;
    public bool end = false;
     
   private void OnCollisionEnter(Collision other) {
    if(other.gameObject.CompareTag("Player1"))
    {
        
        hasInteract = true;
    }
    if(other.gameObject.CompareTag("boxB"))
    {
        Destroy(other.gameObject);
    }
    if(other.gameObject.CompareTag("endgame"))
    {
        
        end = true;
    }
  
   }
   private void OnCollisionExit(Collision other) {
    if(other.gameObject.CompareTag("Player1"))
    {
        
        hasInteract = false;
    }
    
   }
   private void OnTriggerEnter(Collider other) {
      if(other.gameObject.CompareTag("finishpoint"))
    {
        
        haswarp = true;
    }
     if(other.gameObject.CompareTag("biglaser"))
    {
        
        laser = true;
    }
   
   }
   private void OnTriggerExit(Collider other) {
    if(other.gameObject.CompareTag("finishpoint"))
    {
        
        haswarp = false;
    }
   }
}
