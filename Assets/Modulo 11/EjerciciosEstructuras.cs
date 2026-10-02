using System;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    private void Start()
    {
        // 1) Prueba de la lista con num aleatorios
        List<int> listaAleatoria = GenerarListaAleatoria(5, 10, 50);
        Debug.Log($"1) Lista aleatoria generada: {string.Join(", ", listaAleatoria)}");

        // 2) Prueba de orde desendente de arreglo
        int[] numerosDesordenados = { 15, 3, 42, 8, 23, 1 };
        int[] ordenados = OrdenarDescendente(numerosDesordenados);
        Debug.Log($"2) Arreglo ordenado descendente: {string.Join(", ", ordenados)}");

        // 3) Prueba de conversion a HashSet eliminando repetidos
        List<string> listaConDuplicados = new List<string> { "manzana", "pera", "manzana", "uva", "pera", "platano" };
        HashSet<string> sinDuplicados = FiltrarRepetidos(listaConDuplicados);
        Debug.Log($"3) Elementos unicos en HashSet: {string.Join(", ", sinDuplicados)}");

        // 4) Prueba de Stack (pila) a Queue (cola)
        Stack<string> miPila = new Stack<string>();
        miPila.Push("Elemento 1");
        miPila.Push("Elemento 2");
        miPila.Push("Elemento 3");

        Debug.Log("--- 4) Procesando Pila y Cola ---");
        ProcesarPilaYCola(miPila);
    }

    // 1) Lista enteros aleatorios usando Random
    public List<int> GenerarListaAleatoria(int tamano, int rangoInferior, int rangoSuperior)
    {
        List<int> resultado = new List<int>();

        for (int i = 0; i < tamano; i++)
        {
            
            int aleatorio = UnityEngine.Random.Range(rangoInferior, rangoSuperior + 1);
            resultado.Add(aleatorio);
        }

        return resultado;
    }

    // 2) Aarreglo de enteros y regresa uno nuevo ordenado de forma descendente
    public int[] OrdenarDescendente(int[] arregloOriginal)
    {
        
        int[] copia = (int[])arregloOriginal.Clone();

      
        Array.Sort(copia);
        Array.Reverse(copia);

        return copia;
    }

    // 3)Llista con duplicados y retorna un HashSet con valores unicos
    public HashSet<string> FiltrarRepetidos(List<string> listaEntrada)
    {
        HashSet<string> hashSetResultado = new HashSet<string>();

        // Agregamos comprobando si no lo contiene ya (o pasandolo directo al HashSet)
        foreach (string elemento in listaEntrada)
        {
            if (!hashSetResultado.Contains(elemento))
            {
                hashSetResultado.Add(elemento);
            }
        }

        return hashSetResultado;
    }

    // 4) Pasa elementos de una pila (Stack) a una cola (Queue) usando peek, pop y enqueue
    public void ProcesarPilaYCola(Stack<string> pila)
    {
        Queue<string> cola = new Queue<string>();

        Debug.Log("Vaciando pila y copiando a la cola:");
        // Recorremos la pila mientras no este vacia
        while (pila.Count > 0)
        {
            // Usamos Peek para inspeccionar el elemento superior antes de sacarlo
            string elementoSuperior = pila.Peek();
            Debug.Log($"Pila Peek: {elementoSuperior}");

            // Metemos el elemento a la cola (Enqueue) y lo removemos de la pila (Pop)
            cola.Enqueue(pila.Pop());
        }

        Debug.Log("Leyendo e imprimiendo elementos de la cola:");
        // Recorremos la cola mientras tenga elementos
        while (cola.Count > 0)
        {
            // Peek para revisar
            string elementoFrente = cola.Peek();
            Debug.Log($"Cola Peek: {elementoFrente} -> Dequeue: {cola.Dequeue()}");
        }
    }
}