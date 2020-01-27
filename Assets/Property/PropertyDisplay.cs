using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyDisplay : MonoBehaviour
{
    public PropertyPlayer propertyPlayer;
    void Start()
    {
        print(propertyPlayer.hp);
        propertyPlayer.hp = 30;  //pubicだと他のクラスの変数を書き換えてしますことが出来てしまう、そこでプロパティーを使用する

        print(propertyPlayer.Hp);
        // propertyPlayer.Hp = 30;  //変数を変えようとするとerrorになり、プロパティーが効いていることがわかる


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
