using UnityEngine;

public class CubeSpawnerUpdate : MonoBehaviour
{
    public GameObject CuboPrefab;
    public int NumeroDeCubos;

    void Update()
    {
        NumeroDeCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(CuboPrefab);
        tempGameObject.name = "Cubo " + NumeroDeCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;
    }
}