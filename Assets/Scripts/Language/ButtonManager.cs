using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] public bool _button1selected;
    [SerializeField] private bool _button2selected;

    [SerializeField] private Sprite _selectedSprite;
    [SerializeField] private Sprite _notselectedSprite;

    private Button btn1, btn2;

    public void BtnClicked(int btnIndex)
    {
        if (btnIndex == 1)
        {
            if (_button1selected)
            {
                btn1.GetComponent<Button>().image.sprite = _notselectedSprite;
            }
            else
            {
                btn1.GetComponent<Button>().image.sprite = _selectedSprite;
            }
            _button1selected = !_button1selected;
        }
        else
        {
            if (_button2selected)
            {
                btn2.GetComponent<Button>().image.sprite = _notselectedSprite;
            }
            else
            {
                btn2.GetComponent<Button>().image.sprite = _selectedSprite;  
            }
            _button2selected = !_button2selected;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
