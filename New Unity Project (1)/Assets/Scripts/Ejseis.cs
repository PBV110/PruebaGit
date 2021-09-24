using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejseis : MonoBehaviour
{
    
    public int[] arrayNumeros;
    public int may;
    public int seis;

    void Start()
    {
       for (int i = 0; i < 10; i++)                  //Esto es para calcular el numero de 6s
        {
            if (arrayNumeros[i] == 6)
                seis = seis + 1;

        }
        Debug.Log("Numero de 6s: " + seis);

       for (int i = 0; i < 10; i++)                  //Esto es para calcular el numero mas grande
        {
          if (arrayNumeros[i] >may)
                              may =  arrayNumeros[i];

        }
        Debug.Log("El numero mayor es: " + may);



        
    }

}
