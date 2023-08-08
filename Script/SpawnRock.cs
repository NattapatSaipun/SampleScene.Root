using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnRock : MonoBehaviour
{
    public  GameObject rock;

    [SerializeField] float timimg = 3f;
    float tm;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        tm += 1 * Time.deltaTime;
        if(tm >= timimg)
        {
            Instantiate(rock, transform.position, Quaternion.identity);
           tm = 0;
        }
       
    }
   
}
