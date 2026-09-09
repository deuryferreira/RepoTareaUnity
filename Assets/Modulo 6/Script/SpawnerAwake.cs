using UnityEngine;

public class CubeSpawnerAwake: MonoBehaviour
{
    public GameObject CuboPrefab;

    private void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(CuboPrefab);
        tempGameObject.name = "Cubo 1";
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;
    }
}