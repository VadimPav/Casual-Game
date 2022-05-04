using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneControl : MonoBehaviour
{
   private void FixedUpdate()
   {
      if (Input.GetKey(KeyCode.R))
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      if (Input.GetKey(KeyCode.Q))
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
