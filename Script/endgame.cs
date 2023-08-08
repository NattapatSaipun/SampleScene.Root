using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour
{
    
    [SerializeField] Interact p1;
    [SerializeField] InteractP2 p2;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(p1.end && p2.end)
        {
           SceneManager.LoadScene(0);
        }
    }
}
