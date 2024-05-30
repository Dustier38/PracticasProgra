// Librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Clases

public class Calculadora : MonoBehaviour
{
    // Variables
    public TMP_InputField primerNumero;
    public TMP_InputField segundoNumero;
    public TMP_Text resultadoText;
    public int resultado;

    // Metodos

    public void Suma()
    {
        int numero1 = int.Parse(primerNumero.text);
        int numero2 = int.Parse(segundoNumero.text);

        resultado = numero1 + numero2;

        resultadoText.text = resultado.ToString();
    
    }
    public void Resta()
    {
        int numero1 = int.Parse(primerNumero.text);
        int numero2 = int.Parse(segundoNumero.text);

        resultado = numero1 - numero2;

        resultadoText.text = resultado.ToString();

    }
    public void Multiplicacion()
    {
        int numero1 = int.Parse(primerNumero.text);
        int numero2 = int.Parse(segundoNumero.text);

        resultado = numero1 * numero2;

        resultadoText.text = resultado.ToString();

    }
    public void Division()
    {
        int numero1 = int.Parse(primerNumero.text);
        int numero2 = int.Parse(segundoNumero.text);

        resultado = numero1 / numero2;

        resultadoText.text = resultado.ToString();

    }
}
