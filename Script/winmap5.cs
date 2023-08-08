using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winmap5 : MonoBehaviour
{
    public int num;
    private void OnTriggerEnter(Collider other) {
    if(other.gameObject.tag.Equals("finishpoint"))
    {
        SceneManager.LoadScene(num);
    }
    }
}
