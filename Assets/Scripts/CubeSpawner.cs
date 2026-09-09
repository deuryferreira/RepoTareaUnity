using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class CubeSpawner : MonoBehaviour
{
    public GameObject CuboPrefab; // Reference to the cube prefab
    public List<GameObject> ListaDeCubos;
    public float FactorDeEscala;
    public int NumeroDeCubos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ListaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        NumeroDeCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(CuboPrefab);
        tempGameObject.name = "Cubo " + NumeroDeCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position= Random.insideUnitSphere;

        ListaDeCubos.Add(tempGameObject);
        List<GameObject> cubosParaEliminar = new List<GameObject>();

        foreach (GameObject go in ListaDeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= FactorDeEscala;
            go.transform.localScale = Vector3.one * scale;


            if (scale <= 0.1)
            {
                cubosParaEliminar.Add(go); 
            }
        }

        foreach (GameObject go in cubosParaEliminar)
        {
            ListaDeCubos.Remove(go);
            Destroy(go);
        }
    }
}
