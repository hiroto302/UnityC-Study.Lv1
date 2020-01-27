using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    // Switch分 値により行う処理を変化

    void Start()
    {
        int playerLevel = 10;
        GetSkill(playerLevel);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetSkill(int lv)
    {
        switch(lv)
        {
            case 5:
                print("ひのこ");
                break;
            case 10:
                print("電光石火");
                break;
        }
        
    }


}
