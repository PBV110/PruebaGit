using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{
    public GameObject Objeto;
    public int numeroobj = 5;

    public int[] arrayNumeros;
    public int sum ;

    // Start is called before the first frame update

    void Start()
    {
      
       /* for (int i = 0; i < numeroobj; i++)
        {
            Instantiate(Objeto, new Vector3(0.0f, 5, 5 * (i+1)), Quaternion.identity);
        }
       */

        for (int i = 0; i<10; i++)
        {
            sum = sum + arrayNumeros[i];
            
        }
        Debug.Log(sum);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
