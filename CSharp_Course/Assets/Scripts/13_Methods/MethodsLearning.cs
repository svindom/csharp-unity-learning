using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodsLearning : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ChangeColor(cube, Color.blue);
            ChangeRandomColor();
        }
    }

    private void ChangeColor(GameObject obj, Color colorToAssign)
    {
        obj.GetComponent<MeshRenderer>().material.color = colorToAssign;   
    }

    private void ChangeRandomColor()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null ) 
        {
            renderer.material.color = newColor; 
        }
    }
}
