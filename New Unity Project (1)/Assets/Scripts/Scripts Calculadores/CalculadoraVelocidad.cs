using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculadoraVelocidad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Velocidad = " + Velocidad(450f, 20f) + " m/s"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // v = d / t

    float Velocidad(float dis, float tiem)
    {
        float v = dis / tiem;

        return v;
    }
}
