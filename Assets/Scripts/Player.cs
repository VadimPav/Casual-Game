using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] private KeyCode keyOne;
    [SerializeField] private KeyCode keyTwo;
    [SerializeField] private int z;
    [SerializeField] private int x;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Vector3 moveDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
#if UNITY_ANDROID || UNITY_EDITOR
    public void MoveVertical(int inputAxis)
    {  
        z = inputAxis;
        rb.velocity = new Vector3(0, 0, rb.velocity.z + z);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3 (x , moveDirection.y, z);
    }
    public void MoveHorizontal(int inputAxis)
    {   
        x = inputAxis;
        rb.velocity = new Vector3(x, 0, 0);
    }
#elif UNITY_EDITOR || UNITY_64    
    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
            rb.velocity  += moveDirection;
        if (Input.GetKey(keyTwo))
            rb.velocity -= moveDirection;
    }
#endif   
    
}
