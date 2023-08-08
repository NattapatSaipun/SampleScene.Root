using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evolution : MonoBehaviour
{

    public GameObject E1;
    public GameObject E2;
    // Start is called before the first frame update
    void Start()
    {
        E2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            E1.SetActive(false);
            E2.SetActive(true);
        }
    }
}
