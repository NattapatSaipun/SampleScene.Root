using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject panel;
    public GameObject startpanel;

    // Start is called before the first frame update
    void Start()
    {
      
       
             Time.timeScale = 0;
        
        
       panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pauseMenu();
    }
    public void StartShowMenu()
    {
        startpanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void StartHideMenu()
    {
        startpanel.SetActive(false);
        Time.timeScale = 1;
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
