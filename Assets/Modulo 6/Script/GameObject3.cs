using UnityEngine;

public class GameObject3 : MonoBehaviour
{
    private Renderer rend;

    private void Awake()
    {
        // Guardar la referencia al iniciar para no sobrecargar el bucle de físicas
        rend = GetComponent<Renderer>();
    }

    // FixedUpdate se ejecuta a intervalos fijos independientes del framerate
    private void FixedUpdate()
    {
        Color c = new Color(Random.value, Random.value, Random.value, 1f);
        rend.material.color = c;
    }
}