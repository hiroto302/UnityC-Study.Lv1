using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 型の変換
    void Start()
    {
        //intからstringへの変換
        int a = 100;
        string b = a.ToString();

        // stringからintへの変換
        string c ="200";
        int d = int.Parse(c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
