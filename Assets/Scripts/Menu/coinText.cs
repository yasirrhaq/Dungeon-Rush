using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinText : MonoBehaviour
{
    public Text coin;
    
    // Update is called once per frame
    void Update()
    {
        coin.text = GameMaster.instance.allCoin.ToString();
    }
}
