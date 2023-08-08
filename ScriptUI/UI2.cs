using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI2 : MonoBehaviour
{
   
    public GameObject panel;
    

    // Start is called before the first frame update
    void Start()
    {
      
        
       panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pauseMenu();
    }
  
    public void ShowMenu()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void HideMenu()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
    public void pauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowMenu();
        }
    }
}
