using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public int speedFactor = 9;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FirstPersonMovement>())
        {
            other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
        }

        

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<FirstPersonMovement>())
        {
            other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
        }
        
    }

}
    