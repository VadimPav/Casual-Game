using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTemplateProjects;

public class Activator : MonoBehaviour
{
    [SerializeField] private List<GroupElement> firstGroup;
    [SerializeField] private List<GroupElement> secondGroup;
    [SerializeField] private Activator _button;
    [SerializeField] private Material normal;
    [SerializeField] private Material transparent;
    
    private Renderer _rd;
    
    public bool canPush;
    
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
                foreach (GroupElement first in firstGroup)
                {
                    first.SetRenderer(normal);
                    first.SetCollider(false);
                }

                foreach (GroupElement second in secondGroup)
                {
                    second.SetRenderer(transparent);
                    second.SetCollider(true);
                }

                _rd.material = transparent;
                _button._rd.material = normal;
                _button.canPush = true;
            }
        }
    }
}
