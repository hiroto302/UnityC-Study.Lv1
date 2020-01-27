using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyPlayer : MonoBehaviour
{
    // private int hp = 100;  //デフォルトだとprivateになっている
    public int hp = 100;

    // プロパティー
    // プロパティーを使用する場合、凡例として変数の頭文字は大文字
    // get; 読み取り  set; 書き込み
    // private setとすることで、他のクラスでは書き込みをすることが出来ないように指定することができる
    public int Hp { get; private set;} = 200;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
