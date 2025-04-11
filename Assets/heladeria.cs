using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heladeria : MonoBehaviour
{
    public string sabor;
    public float pesoHelado;
    float valorHelado = 1.25f;
    float precioFinal;
    // Start is called before the first frame update
    void Start()
    {
        if (pesoHelado < 250 || pesoHelado > 3000)
        {
            Debug.Log("Error, la cantidad de helado pedida no es valida.");
        }
        else
        {
            if (sabor == "DDL" || sabor == "CHO")
            {
                precioFinal = valorHelado * pesoHelado;
                Debug.Log("El monto a pagar por " + pesoHelado + " gramos de helado es $" + precioFinal + " pesos.");
            }
            else if(sabor == "FRU")
            {
                precioFinal = valorHelado * pesoHelado * 0.90f;
                Debug.Log("El monto a pagar por " + pesoHelado + " gramos de helado es $" + precioFinal + " pesos.");
            }
            else
            {
                Debug.Log("Error, el sabor elegido no es valido.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
