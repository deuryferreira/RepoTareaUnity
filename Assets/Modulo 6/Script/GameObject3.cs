using UnityEngine;

public class GameObject3 : MonoBehaviour
{
    // Referencias a los scripts de los dos primeros GameObjects
    [SerializeField] private GameObject1 go1;
    [SerializeField] private GameObject2 go2;

    // Variable booleana calculada a partir de los otros dos
    public bool isWhite;

    private Renderer rend;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    private void FixedUpdate()
    {
        // Comprobar que ambas referencias estén asignadas para evitar NullReferenceException
        if (go1 == null || go2 == null)
        {
            return;
        }

        // 7) El valor depende de un AND (&&): solo será true si ambos son true
        isWhite = go1.isWhite && go2.isWhite;

        // Evaluación de color: blanco si el resultado es true, negro si es false
        rend.material.color = isWhite ? Color.white : Color.black;
    }
}