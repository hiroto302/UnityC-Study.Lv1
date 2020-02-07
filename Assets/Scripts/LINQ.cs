using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LINQ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, int> scores = new Dictionary<string, int>()
        {
            {"taro",1},
            {"jiro",2},
            {"saburo",3}
        };

        // int sum = 0;
        // foreach(KeyValuePair<string, int> v in scores)
        // {
        //     sum += v.Value;
        // }

        // 上記をラムダ式で記述
        // int sum = scores.Sum((KeyValuePair<string,int> v) => {return v.Value; });  //合計値の計算
        int sum = scores.Sum( v => v.Value );  //省略形
        Debug.Log(sum);

        // ラムダ式の仕様例
        // Sum 合計、 Average 平均、Max 最大、Min 最小
        // Select データを変換しコピーする
        // Where データ選択
        // OrderBy
        // データをソート
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
