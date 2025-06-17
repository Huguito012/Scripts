using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{
    public float speed;
    public float TDV;
    private float TDVActual;

    private void Start()
    {
        TDVActual = TDV;
    }
    private void Update()
    {
        TDVActual -= Time.deltaTime;
        if (TDVActual >= 0)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if(TDVActual < 0 && TDVActual > -5)
        {
            transform.position += transform.up * -speed * Time.deltaTime;
        }

        else if (TDVActual <= -5)
        {
            TDVActual = TDV;
        }
    }
    
}
