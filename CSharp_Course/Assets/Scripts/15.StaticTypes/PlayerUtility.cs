using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUtility : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UtilityClass.CreateObject();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            UtilityClass.SetPositionToZero(this.gameObject);
        }
    }
}
