using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnlaser : MonoBehaviour
{
   
    public  GameObject laser;
    public  Interact p1;
    public InteractP2 p2;

    bool act = false;

    
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if(p1.laser  && !act)
        {
            Instantiate(laser, transform.position, Quaternion.identity);
            p1.laser = false;
            p2.laser = false;
            act = true;
        }
         if( p2.laser && !act)
        {
            Instantiate(laser, transform.position, Quaternion.identity);
            p1.laser = false;
            p2.laser = false;
            act = true;
        }
       
    }
}
