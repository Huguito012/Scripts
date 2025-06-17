using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportacion : MonoBehaviour
{
    public Transform lugarDeDestino;

    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Player>())
        {
            other.transform.position = lugarDeDestino.position;
        }
    }
}
