using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        // 型推論 ローカル変数でのみ使用可能
        // 代入される右側の形式により予測された型が入る
        var hp = 100;
        var st = "hello";
        var c = new Vector3(1, 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
