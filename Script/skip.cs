using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skip : MonoBehaviour
{
    [SerializeField] int num;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene(num);
        }
    }
}
