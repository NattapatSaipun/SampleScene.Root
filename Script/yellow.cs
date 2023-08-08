using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow : MonoBehaviour
{
    public bool hasInteract = false;
    private void OnCollisionEnter(Collision other) {
         if(other.gameObject.CompareTag("yellow"))
    {
        hasInteract = true;
    }
    }
    private void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("yellow"))
    {
        hasInteract = false;
    }
    }
}
