using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculadoraDistancia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Distancia = " + Distancia(22.5f, 20f) + " m");
    }

    // Update is called once per frame
    void Update()
    {

    }


    // v = d / t
    // d = v*t
    // t= d/v
    float Distancia(float vel, float tiem)
    {
        float d = vel * tiem;

        return d;
    }
}
