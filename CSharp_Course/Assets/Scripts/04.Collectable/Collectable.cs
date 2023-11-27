using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // also you can:
            // add points
            // add power up ability
            // etc.
            Destroy(this.gameObject);
        }
    }
}
