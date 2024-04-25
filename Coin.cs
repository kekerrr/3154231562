using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int price = 2;

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.ChangeCoins(price);
        Destroy(gameObject);
    }

}