using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if ( other.CompareTag("Cube"))
        {
            foreach (Activator button in FindObjectsOfType<Activator>())
            {
                button.canPush = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if ( other.CompareTag("Cube"))
        {
            foreach (Activator button in FindObjectsOfType<Activator>())
            {
                button.canPush = true;
            }
        }
    }
}
