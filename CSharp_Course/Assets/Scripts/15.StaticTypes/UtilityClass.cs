using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public static class UtilityClass
{
    public static void CreateObject()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
    public static void SetPositionToZero(GameObject gameObject)
    {
        gameObject.transform.position = Vector3.zero;
    }
}
