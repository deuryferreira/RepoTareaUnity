using UnityEngine;

public class EjerciciosArreglos : MonoBehaviour
{
    private void Start()
    {
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
    }

    // 1) Arreglos unidimensionales con Random.Range y suma en un terser arreglo
    private void Ejercicio1()
    {
        int tamano = 5;
        int[] arr1 = new int[tamano];
        int[] arr2 = new int[tamano];
        int[] arr3 = new int[tamano];

        // Llenamos con numeros enteros aleatorios (el maximo no se incluye)
        for (int i = 0; i < tamano; i++)
        {
            arr1[i] = Random.Range(1, 11);
            arr2[i] = Random.Range(1, 11);
        }

        // Sumamos los elementos de ambos arreglos
        for (int i = 0; i < tamano; i++)
        {
            arr3[i] = arr1[i] + arr2[i];
            Debug.Log($"E1 -> arr3[{i}] = arr1[{arr1[i]}] + arr2[{arr2[i]}] = {arr3[i]}");
        }
    }

    // 2) Concatenar palabras de una oracion usando foreach
    private void Ejercicio2()
    {
        string[] palabras = { "Desarrollo", "de", "videojuegos", "con", "Unity", "y", "C#" };
        string oracionCompleta = "";

        // Recorido de cada palabra
        foreach (string palabra in palabras)
        {
            oracionCompleta += palabra + " ";
        }

        oracionCompleta = oracionCompleta.TrimEnd(); // quitamos el espasio que sobra al final
        Debug.Log($"E2 -> Oracion completa: \"{oracionCompleta}\"");
    }

    // 3) Multiplicacion de matriz (2 renglones x 3 columnas) por vector
    // 3) Multiplicacion de matriz (2 renglones x 3 columnas) por vector
    private void Ejercicio3()
    {
        // Matris de 2x3
        int[,] matriz = new int[2, 3]
        {
            { 2, 3, 4 },
            { 1, 5, 2 }
        };

        // Vector columna con 3 elemento
        int[] vector = { 2, 4, 3 };

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int[] resultado = new int[filas];

        // Calculo de la multiplicacion matriz * vector
        // Calculo de la multiplicacion matriz * vector
        for (int i = 0; i < filas; i++)
        {
            int sumaFila = 0;
            for (int j = 0; j < columnas; j++)
            {
                sumaFila += matriz[i, j] * vector[j];
            }
            resultado[i] = sumaFila;
            Debug.Log($"E3 -> Resultado renglon [{i}]: {resultado[i]}");
        }
    }
}