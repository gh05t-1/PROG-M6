using UnityEngine;
using TMPro;
using System;
public class coinUI : MonoBehaviour
{

    [SerializeField] private TMP_Text _coinCountText;
    private int _coinCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coin.onCoinCollected += CoinUi;
    }

    void CoinUi()
    {
        _coinCount++;
        Text();
    }

    void Text()
    {
        _coinCountText.text = "Coins " + _coinCount;
    }

    private void OnDestroy()
    {
        coin.onCoinCollected -= CoinUi;
    }
}
