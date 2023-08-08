using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChang : MonoBehaviour
{
    [SerializeField] Interact p1;
    [SerializeField] InteractP2 p2;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(p1.haswarp && p2.haswarp2)
        {
           SceneManager.LoadScene(num);
        }
    }
}
