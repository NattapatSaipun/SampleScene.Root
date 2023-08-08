using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winmap4 : MonoBehaviour
{
    [SerializeField] red rock;
    [SerializeField] blue rock2;
    [SerializeField] green rock3;
    [SerializeField] yellow rock4;
    [SerializeField] GameObject win;
  private void Update() {
    if(rock.hasInteract&&rock2.hasInteract&&rock3.hasInteract&&rock4.hasInteract)
    {
      win.SetActive(true);
    }
  }
  
}
