using UnityEngine;

public class Componente2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
    }
    void Start()
    {
        Debug.Log(Componente1.myGameObject1.name);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
