using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSimpleMovement : MonoBehaviour
{
    [SerializeField]
    private float _speedCube = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        //              new vector3(1, 0, 0) * 5 * real time
        transform.Translate(new Vector3(horizontalInput, 0, 0) * _speedCube * Time.deltaTime);
    }
}
