using UnityEngine;

public class GameObject2 : MonoBehaviour
{
    // Variable booleana requerida para el cambio de estado
    public bool isWhite = true;

    private Renderer rend;

    private void Awake()
    {
        // Guardamos la referencia una sola vez para no usar GetComponent en cada frame
        rend = GetComponent<Renderer>();
    }

    /*
    // Update is called once per frame
    void Update()
    {
        // Genera un color aleatorio en cada fotograma
        Color c = new Color(Random.value, Random.value, Random.value, 1f);

        // Aplica el color al material del objeto
        rend.material.color = c;
    }
    */

    private void FixedUpdate()
    {
        // Alterna entre verdadero y falso en cada paso de físicas
        isWhite = !isWhite;

        // Aplica blanco si es verdadero o negro si es falso
        rend.material.color = isWhite ? Color.white : Color.black;
    }
}