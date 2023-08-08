using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class green : MonoBehaviour
{
  
    public bool hasInteract = false;
    private void OnCollisionEnter(Collision other) {
         if(other.gameObject.CompareTag("green"))
    {
        hasInteract = true;
    }
    }
    private void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("green"))
    {
        hasInteract = false;
    }
    }
}
