using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwither : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Finish") && other.CompareTag("Player"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
