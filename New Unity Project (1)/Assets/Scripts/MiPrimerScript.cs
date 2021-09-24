using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
    int numero = 1;

    // Start is called before the first frame update
    void Start()
    {
        ShowHealth();
        numero = numero - 6;

        ShowHealth();
        numero = numero * 5;

        ShowHealth();
        numero = numero / 4 + 4;

        ShowHealth();
    }

    void ShowHealth()

    {
        Debug.Log("Tienes " + numero + " puntos de vida!");

    }

}