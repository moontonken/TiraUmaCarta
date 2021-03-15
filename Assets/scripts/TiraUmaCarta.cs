using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiraUmaCarta : MonoBehaviour
{
    int cartas;
    int naipe;

    // Start is called before the first frame update
    void Start() 
        
    {
        Debug.Log("Olá!");
        Debug.Log("Carrega no espaço para obteres uma carta.");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var numeros = new List<string> { "ás", "2", "3", "4", "5", "6", "7", "8", "9", "10", "valete", "dama", "rei" };
            var letras = new List<string> { "copas", "ouros", "paus", "espadas" };

            cartas = Random.Range(1, numeros.Count);
            naipe = Random.Range(1, letras.Count);

            Debug.Log("Saiu o " + numeros[cartas] + " de " + letras[naipe] );

            Debug.Log("Pressiona o espaço para obteres outra carta.");

        }
            



    }
   

        
}

