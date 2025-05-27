using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    public int playerDamage;


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.GetComponent<Player>())
        {
            Player playerVariable = other.GetComponent<Player>();

            Player player = other.GetComponent<Player>();

            player.TakeDamage(playerDamage);
        }
    }
}
