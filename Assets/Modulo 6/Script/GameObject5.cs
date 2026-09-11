using UnityEngine;

public class GameObject5 : MonoBehaviour
{
    // Referencias a los scripts de los dos cubos anteriores (GO 3 y GO 4)
    [SerializeField] private GameObject3 go3;
    [SerializeField] private GameObject4 go4;

    // Variable booleana resultante de la combinación
    public bool isWhite;

    private Renderer rend;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    private void FixedUpdate()
    {
        // Validar que ambas referencias estén asignadas
        if (go3 == null || go4 == null)
        {
            return;
        }

        // Combinación mediante operación AND (&&):
        // Solo será true si tanto el resultado de GO 3 como el de GO 4 son true
        isWhite = go3.isWhite && go4.isWhite;

        // Asignar color: blanco si es true, negro si es false
        rend.material.color = isWhite ? Color.white : Color.black;
    }
}