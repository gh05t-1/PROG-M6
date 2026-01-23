using System;
using UnityEngine;

public class coin : MonoBehaviour
{
    

    public static Action onCoinCollected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onCoinCollected.Invoke();
            Destroy(gameObject);
        }
    }
}
