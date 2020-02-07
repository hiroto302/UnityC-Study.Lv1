using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Dictionary<string, int> scores = new Dictionary<string, int>()
    {
        {"taro", 0},
        {"jiro", 0}
    };

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            scores["taro"]++;
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            scores["jiro"]++;
        }
        foreach(KeyValuePair<string, int> s in scores)
        {
            Debug.Log(s.Key + "" + s.Value);
        }
    }
}
