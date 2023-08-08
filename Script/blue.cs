using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue : MonoBehaviour
{
   
    public bool hasInteract = false;
    private void OnCollisionEnter(Collision other) {
         if(other.gameObject.CompareTag("blue"))
    {
        hasInteract = true;
    }
    }
    private void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("blue"))
    {
        hasInteract = false;
    }
    }
}
