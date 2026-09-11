using UnityEngine;

public class GameObject4 : MonoBehaviour
{
    // Referencias a los scripts de los dos primeros GameObjects
    [SerializeField] private GameObject1 go1;
    [SerializeField] private GameObject2 go2;

    // Variable booleana calculada a partir del operador OR
    public bool isWhite;

    private Renderer rend;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    private void FixedUpdate()
    {
        // Validación de referencias para evitar NullReferenceException
        if (go1 == null || go2 == null)
        {
            return;
        }

        // Evaluación lógica con el operador OR (||)
        isWhite = go1.isWhite || go2.isWhite;

        // Asignación de color: blanco si es verdadero, negro si es falso
        rend.material.color = isWhite ? Color.white : Color.black;
    }
}