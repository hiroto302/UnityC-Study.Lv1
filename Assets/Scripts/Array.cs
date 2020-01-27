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

        //foreach
        int[] nums = {4, 5, 6};
        foreach(var num in nums)  //配列の全ての要素に下記の処理を行う
        {
            print(num);
        }

        //List  配列への要素の追加
        // List<int> nums = new List<int>();
        // var numbers = new List<int>();
        // numbers.Add(7);  要素の追加
        // numbers.Add(8);
        // numbers.Add(9);
        // print(numbers[1]);
        // foreach(var count in numbers)
        // {
        //     print(count);
        // }

        // Listに初期値を与える
        List<int> numbers = new List<int>(){7, 8, 9};
        foreach(var count in numbers)
        {
            print(count);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
