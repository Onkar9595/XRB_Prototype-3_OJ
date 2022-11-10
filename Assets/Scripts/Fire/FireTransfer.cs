using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class FireTransfer : MonoBehaviour
{

    [SerializeField] private GameObject _fireprefab;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FireSource"))
        {
            _fireprefab.SetActive(true);
        }
        if (other.CompareTag("FireKill"))
        {
            _fireprefab.SetActive(false);  
        }
    }
    void Start()
    {
        _fireprefab.SetActive(false);
    }
}
