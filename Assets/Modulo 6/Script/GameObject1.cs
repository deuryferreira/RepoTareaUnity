using UnityEngine;

public class GameObject1 : MonoBehaviour
   
{
    private void Awake()
    {
      
        Color c = new Color(Random.value, Random.value, Random.value, 1f);

      
        GetComponent<MeshRenderer>().material.color = c;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
