using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] GameObject player;
   
    // Update is called once per frame
    void Update()
    {
   
    }
   
   private void OnTriggerEnter(Collider other) {
    if(other.gameObject.tag.Equals("checkdead"))
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag.Equals("rock"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(other.gameObject.tag.Equals("checkdead"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
