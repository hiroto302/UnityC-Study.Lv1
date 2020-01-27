using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour
{
    //グローバル変数  クラスの波括弧の中に記述  このクラス内であればどこででも使用できる
    int hp = 100;

    void Start()
    {
        Debug.Log(hp);

        //ローカル変数  このメソッド内でのみ使用可能
        int mp = 300;

        if(mp == 300)
        {
            int a = 3000;  //このようにif文の中で作成した変数は、そのif文のみで使用可能
            Debug.Log(a);  //errorにならない
        }

        // Debug.Log(a);  errorになる
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
