using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SelectionLogic : MonoBehaviour
{
    [SerializeField] public Sprite _winningSprite;
    [SerializeField] public Sprite _loosingSprite;

    [SerializeField] public Material _winningMaterial1;
    [SerializeField] public Material _winningMaterial2;
    
    [SerializeField] private Image _selectedImage;
    [SerializeField] private Button _selectedButton;
    //public bool correctAnswer1Selected;
    //public bool correctAnswer2Selected;
    [SerializeField] private ParticleSystem _celebrationParticle;

    public void Start()
    {
        //correctAnswer1Selected = false;
        //correctAnswer2Selected = false;
    }

    public void WinningCondition()
    {
        if (_selectedImage.material == _winningMaterial1 || _selectedImage.material == _winningMaterial2)
        {
            _selectedButton.image.sprite = _winningSprite;
        }
        else
        {
            _selectedButton.image.sprite = _loosingSprite;
        }
        
      /*  if (_selectedImage.material == _winningMaterial1)
        {
            correctAnswer1Selected = true;
        }
        
        if (_selectedImage.material == _winningMaterial1)
        {
            correctAnswer2Selected = true;
        }
        */
       
    }

   // public void ContextComplete()
   // {
       
   // }
    
}
