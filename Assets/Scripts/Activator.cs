using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField] private GameObject[] firstGroup;
    [SerializeField] private GameObject[] secondGroup;
    [SerializeField] private Activator _button;
    [SerializeField] private Material normal;
    [SerializeField] private Material transparent;
    public bool canPush;
    

    private Renderer _rd;
    private void Start()
    {
        _rd = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (canPush)
        {
            if (other.CompareTag("Cube") || other.CompareTag("Player"))
            {
                foreach (GameObject first in firstGroup)
                {
                    first.GetComponent<Renderer>().material = normal;
                    first.GetComponent<Collider>().isTrigger = false;
                }

                foreach (GameObject second in secondGroup)
                {
                    second.GetComponent<Renderer>().material = transparent;
                    second.GetComponent<Collider>().isTrigger = true;
                }

                _rd.material = transparent;
                _button._rd.material = normal;
                _button.canPush = true;
            }
        }
    }
}
