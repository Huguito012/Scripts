using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.GetComponent<Player>())
        {
            Player playerVariable = other.GetComponent<Player>();

            playerVariable.CollectCoins();

            Destroy(gameObject);
        }
    }
}