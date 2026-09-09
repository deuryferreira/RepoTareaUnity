using UnityEngine;

public class SpawnerDisableDestroy : MonoBehaviour
{
    [SerializeField] private GameObject cuboPrefabOnDestroy;

    private void OnDisable()
    {
        // Importante: comprobar si la aplicación sigue en ejecución para no
        // generar objetos huérfanos al detener el modo Play en el editor.
        if (cuboPrefabOnDestroy != null && gameObject.scene.isLoaded)
        {
            CrearCubo("Cubo OnDisable");
        }
    }

    private void OnDestroy()
    {
        // Opcional: si la lección contemplaba OnDestroy
        if (cuboPrefabOnDestroy != null && gameObject.scene.isLoaded)
        {
            CrearCubo("Cubo OnDestroy");
        }
    }

    private void CrearCubo(string nombre)
    {
        GameObject temp = Instantiate(cuboPrefabOnDestroy);
        temp.name = nombre;
        temp.transform.position = Random.insideUnitSphere;

        Color c = new Color(Random.value, Random.value, Random.value, 1f);
        temp.GetComponent<MeshRenderer>().material.color = c;
    }
}