using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red : MonoBehaviour
{
    public bool hasInteract = false;
    private void OnCollisionEnter(Collision other) {
         if(other.gameObject.CompareTag("red"))
    {
        hasInteract = true;
    }
    }
    private void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("red"))
    {
        hasInteract = false;
    }
    }
}
