using System;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int coinAmount = 0;

    public Action onCoinCollected;
    
    public void CoinPickedUp()
    {
        onCoinCollected?. Invoke();
    }
}
