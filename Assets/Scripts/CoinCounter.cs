using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public Text Text;
    public int coins = 0;

    // Update is called once per frame
    void Update()
    {
        Text.text = "Coins : " + coins;
    }
}
