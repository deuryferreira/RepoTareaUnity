using System;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosCsharp : MonoBehaviour
{
    // Req 1: Variables de incremento
    private int contadorFrames = 0;
    private float acumuladorFisicas = 1.0f;

    // Req 4: String para switch
    [SerializeField] private string colorElegido = "Rojo";

    private Renderer rend;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    private void Start()
    {
        // Req 2: Operacion float con casteo explicito a int
        float valorA = 12.75f;
        float valorB = 3.40f;
        int resultadoEntero = (int)(valorA + valorB);
        Debug.Log($"Req 2 -> Suma casteada a int: {resultadoEntero}");

        // Req 4: Sentencia switch
        CambiarColorPorNombre(colorElegido);

        // Req 5: Float a string con 4 decimales
        float piAproximado = 3.14159265f;
        Debug.Log($"Req 5 -> Float 4 decimales: {piAproximado.ToString("F4")}");

        // Req 6: Substring y Split
        string nombreCompleto = "Juan Carlos Perez";
        string p1 = nombreCompleto.Substring(0, 4);
        string p2 = nombreCompleto.Substring(5, 6);
        string p3 = nombreCompleto.Substring(12, 5);
        Debug.Log($"Req 6 -> Substring: '{p1}', '{p2}', '{p3}'");

        List<string> listaNombres = new List<string>(nombreCompleto.Split(' '));
        Debug.Log($"Req 6 -> Split a lista ({listaNombres.Count} elementos): {string.Join(", ", listaNombres)}");

        // Nuevos requerimientos:

        // 1) Parseo con TryParse de valores numericos en miles
        string strMiles1 = "1500";
        string strMiles2 = "2500";
        if (int.TryParse(strMiles1, out int num1) && int.TryParse(strMiles2, out int num2))
        {
            int sumaMiles = num1 + num2;
            Debug.Log($"Nuevo 1 -> TryParse suma: {num1} + {num2} = {sumaMiles}");
        }

        // 2) Imprimir caracteres en indices pares usando modulo (%)
        string oracion = "Hola Mundo";
        string caracteresPares = "";
        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                caracteresPares += oracion[i] + (i + 2 < oracion.Length ? ", " : "");
            }
        }
        Debug.Log($"Nuevo 2 -> Caracteres en indices pares de '{oracion}': {caracteresPares}");

        // 3) Eliminar los primeros 5 caracteres (usando Remove o Substring)
        string fraseCompleta = "Videojuegos en Unity";
        string fraseRecortada = fraseCompleta.Substring(5); // o fraseCompleta.Remove(0, 5)
        Debug.Log($"Nuevo 3 -> Frase sin los primeros 5 caracteres: '{fraseRecortada}'");
    }

    private void Update()
    {
        // Req 1.a: Incremento por frame
        contadorFrames++;
    }

    private void FixedUpdate()
    {
        // Req 1.b: Incremento con *= en cada paso de fisicas
        acumuladorFisicas *= 1.01f;

        // Req 3: Modulo (%) para par/impar y cambio de color
        bool esPar = (contadorFrames % 2) == 0;
        rend.material.color = esPar ? Color.white : Color.black;
    }

    private void CambiarColorPorNombre(string color)
    {
        switch (color.ToLower())
        {
            case "rojo":
                rend.material.color = Color.red;
                break;
            case "azul":
                rend.material.color = Color.blue;
                break;
            case "verde":
                rend.material.color = Color.green;
                break;
            case "amarillo":
                rend.material.color = Color.yellow;
                break;
            default:
                rend.material.color = Color.gray;
                break;
        }
    }
}