using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class laser : MonoBehaviour
{
   
        

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * -20;
    }
   
}
