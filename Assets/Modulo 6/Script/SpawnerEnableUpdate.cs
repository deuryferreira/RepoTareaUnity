using UnityEngine;

public class CubeSpawnerUpdate : MonoBehaviour
{
    public GameObject CuboPrefab;
    public int NumeroDeCubos;

    bool isWhite = false;
    
    void Update()
    {
        NumeroDeCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(CuboPrefab);
        tempGameObject.name = "Cubo " + NumeroDeCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;
    }

    //private void FixedUpdate()
    //{
    //    isWhite = !isWhite;
    //    if (isWhite)
    //    {
    //        GameObject tempGameObject = Instantiate<GameObject>(CuboPrefab);
    //        tempGameObject.name = "Cubo";
    //        Color c = new Color(1, 1, 1);
    //        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    //        tempGameObject.transform.position = Random.insideUnitSphere;
    //    }
    //    else
    //    {
    //        GameObject tempGameObject = Instantiate<GameObject>(CuboPrefab);
    //        tempGameObject.name = "Cubo";
    //        Color c = new Color(256, 256, 256);
    //        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    //        tempGameObject.transform.position = Random.insideUnitSphere;

    //    }
    //}
}