using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private KeyCode keyOne;
    [SerializeField] private KeyCode keyTwo;
    [SerializeField] private Vector3 moveDirection;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
            _rb.velocity += moveDirection;
        if (Input.GetKey(keyTwo))
            _rb.velocity -= moveDirection;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach (Activator button in FindObjectsOfType<Activator>())
            {
                button.canPush = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach (Activator button in FindObjectsOfType<Activator>())
            {
                button.canPush = true;
            }
        }
    }
}
