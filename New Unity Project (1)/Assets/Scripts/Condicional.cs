using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicional : MonoBehaviour
{

    public int edad = 81;

    // Start is called before the first frame update
    void Start()
    {
        if (edad < 18)                                                                  //Codigo para calcular en base a la edad si se puede votar
        {
            Debug.Log("Es menor de edad y no puede votar");
        }
        else if (edad > 65)
        {
            Debug.Log("Es mayor de edad, pero no puede votar");
        }
        else
        {
            Debug.Log("Es mayor de edad y puede votar");
        }
    }



    // Update is called once per frame
    void Update()
    {
    }
}
