using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    //配列 複数の値を格納ができる また、複数の同じ型の変数を作成することが出来る
    void Start()
    {
        int[] hps = new int[3];  //配列の型を指定し、[]の中に格納したい要素の数を指定  //配列の宣言
        // 参照型の変数ではnewを用いる！？？？
        hps[0] = 10; //配列に要素を格納  [0]とすることで配列の1つ目に10を格納する

        int[] mps = {1, 2, 3};  //配列の型の要素を同時に指定  自動的に格納する分の箱を作成してくれる  //配列の初期化
        Debug.Log(mps[1]);  //2が出力される
        Debug.Log(mps.Length);  //要素数が出力

        float[] f = {0, 1.0f, 1.1f};
        string[] s = {"1", "2", "3"};

        //for
        int[] n = new int[]{1,2,3};
        int sum = 0;
        for(int cnt = 0; cnt < n.Length; cnt++)
        {
            sum += n[cnt];
        }
        Debug.Log(sum);

        //foreach  配列の繰り返し文
        int[] nums = {4, 5, 6};
        foreach(var num in nums)  //配列の全ての要素に下記の処理を行う  inには配列、numにはinで指定した配列の各要素が格納される
        {
            print(num);
        }

        //forで書いた、配列の各要素を足した合計値をシンプルに書くこと出来る
        foreach(int c in n)
        {
            sum += c;
        }


        //List  可変長配列  配列への要素の追加したり減らしたりすることが出来る

        // List<int> nums = new List<int>();
        // var numbers = new List<int>();
        // numbers.Add(7);  要素の追加
        // numbers.Add(8);
        // numbers.Add(9);
        // print(numbers[1]);
        // Debug.Log(numbers.Count);  //要素の数を出力
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

        //Listの例
        // 要素の追加
        // Add, Insert
        // 要素の削除
        // Remove, RemoveAt, Clear


        //連想配列  配列の順番を通常表す番号を、変更することが出来る
        // Dictionaryスクリプトに例を記入

        //LINQ リンク  要素全体に対する処理を実行してくれる
        //LINQスクリプトに例を記入

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
