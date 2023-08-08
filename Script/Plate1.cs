using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate1 : MonoBehaviour
{
  public Rigidbody rb;
  float tm;
  bool hasRun;
  public float timimg = 1.5f;
  private void Start() {
  rb.GetComponent<Rigidbody>().isKinematic = true;
  }
  private void Update() {
    if(hasRun)
    {
        tm += 1 * Time.deltaTime;
   
    if(tm >= timimg)
     {
          rb.GetComponent<Rigidbody>().isKinematic = false;
     }
    }
      
  }
  
  private void OnCollisionEnter(Collision other) {
    if(other.gameObject.tag == "Player"){
      hasRun = true;
  }
 }
}
  
