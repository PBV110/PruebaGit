using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculadoraTiempo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tiempo = " + Tiempo(450f, 22.5f) + " s");
    }

    // Update is called once per frame
    void Update()
    {

    }


    // v = d / t

    float Tiempo(float dis, float vel)
    {
        float t = dis / vel;

        return t;
    }
}
