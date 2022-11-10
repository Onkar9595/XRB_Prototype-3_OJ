using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour
{
    [SerializeField] private Sprite _winningSprite;
    [SerializeField] private Sprite _loosingSprite;

    [SerializeField] private Material _winningMaterial1;
    [SerializeField] private Material _winningMaterial2;

    [SerializeField] private Image _selectedImage;
    [SerializeField] private Button _selectedButton;
    private AudioSource _selectSound;
    
    
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
        _selectSound.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        _selectSound= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
