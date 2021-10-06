using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public CoinCounter counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.Find("Canvas").GetComponent<CoinCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        counter.coins++;
        Destroy(gameObject);
    }
}
