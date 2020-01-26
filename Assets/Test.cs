using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello, World");

        // 変数の型
        // 真偽値
        bool boolean = true;
        print("真偽値:" + boolean);
        //三次元ベクトル
        Vector3 threeVector = new Vector3(1, 5.6f, 3.6f);
        print(threeVector);

        // if文
        // int age = 20;
        // string result;
        // if(age >= 20)
        // {
        //     result ="大人";
        // }
        // else
        // {
        //     result = "子供";
        // }
        // Debug.Log(result);
        
        //条件演算子
        int age = 20;
        string result = age >= 20 ? "大人" : "子供" ;
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
