using UnityEngine;

public class HolaMundo : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Hola Mundo, estoy en el Awake");
    }
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    Debug.Log("Hola Mundo, estoy en el Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning("Esto es un warning en el Update");
        
    }
    private void LateUpdate()
    {
        Debug.LogError("Esto es un error en el LateUpdate");
    }
}
