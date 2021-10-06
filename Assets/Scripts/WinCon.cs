using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCon : MonoBehaviour
{
    public CoinCounter counter;
    void Update()
    {
        if (counter.coins == 10)
        {
            SceneManager.LoadScene(2);
        }
    }
}
