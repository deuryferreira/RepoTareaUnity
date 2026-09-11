using System.ComponentModel;
using UnityEngine;

public class GameObject1 : MonoBehaviour{

    public bool isWhite = true;

    private MeshRenderer meshRenderer;

    private void Awake() {
   
    }

     //Color c = new Color(Random.value, Random.value, Random.value, 1f);
    //GetComponent<MeshRenderer>().material.color = c;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // Si su valor era falso, se vuelve verdadero y viceversa
        isWhite = !isWhite;
        if (isWhite)
        {
            meshRenderer.material.color = Color.white; 
        }
        else
        {
            meshRenderer.material.color = Color.black; 
        }
    }
}
