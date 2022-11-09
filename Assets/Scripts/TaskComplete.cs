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

    public void Update()
    {
        if (_selectedButton1.image.sprite == _winningSprite && _selectedButton2.image.sprite == _winningSprite)
        {
            Debug.Log("You won");
        }
    }

    
}
