using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    //配列 複数の値を格納ができる
    void Start()
    {
        int[] hps = new int[3];  //配列の型を指定し、[]の中に格納したい要素の数を指定
        hps[0] = 10; //配列に要素を格納  [0]とすることで配列の1つ目に10を格納する

        int[] mps = {1, 2, 3};  //配列の型の要素を同時に指定  自動的に格納する分の箱を作成してくれる
        Debug.Log(mps[1]);  //2が出力される
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
