using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int num = 0;
        if(Input.GetKeyDown(KeyCode.A))
        {
            num = 2;
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            num = 3;
        }
        else
        {
            num = 0;
        }

        int a = 1;
        while( a <= num)
        {
            Debug.Log("発射");
            a += 1;
        }


    }
}
