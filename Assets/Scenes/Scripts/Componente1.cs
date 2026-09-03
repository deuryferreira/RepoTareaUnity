using UnityEngine;

public class Componente1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static GameObject myGameObject1;
    void Awake()
    {
        myGameObject1 = this.gameObject;
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
