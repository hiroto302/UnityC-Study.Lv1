using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forTest : MonoBehaviour
{
    //while文とfor文の使い分けはどのような時にくるのか楽しみ
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            print("数値：" + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
