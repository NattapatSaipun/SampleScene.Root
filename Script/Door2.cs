using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
   [SerializeField] Interact p1;
    [SerializeField] InteractP2 p2;
    [SerializeField] Animator door;
    // Start is called before the first frame update
    void Start()
    {
       door.GetComponent<Animator>().Play("New State");
    }

    // Update is called once per frame
    void Update()
    {
        if(p1.hasInteract && p2.hasInteract2)
        {
            
              door.GetComponent<Animator>().Play("door2");
        }
    }
}
