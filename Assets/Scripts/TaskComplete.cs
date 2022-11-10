using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class TaskComplete : SelectionLogic
{
    [SerializeField] private Button _selectedButton1;
    [SerializeField] private Button _selectedButton2;
    [SerializeField] private Canvas potato;
    [SerializeField] private Canvas onion;
    [SerializeField] private Canvas orange;
    [SerializeField] private Canvas washing;
    
    [SerializeField] private Canvas contextDone;
    [SerializeField] private Canvas lightmango;
    [SerializeField] private Canvas lightknife;

    public void Start()
    {
        contextDone.enabled = false;
        lightknife.enabled = false;
        lightmango.enabled = false;
    }
    public void Update()
    {
        if (_selectedButton1.image.sprite == _winningSprite && _selectedButton2.image.sprite == _winningSprite)
        {
            contextDone.enabled = true;
            lightknife.enabled = true;
            lightmango.enabled = true;
            potato.enabled = false;
            onion.enabled = false;
            orange.enabled = false;
            washing.enabled = false;
            Debug.Log("You won");
        }
    }

   



}
