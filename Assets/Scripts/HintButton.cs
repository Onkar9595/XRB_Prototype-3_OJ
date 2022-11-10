using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class HintButton : MonoBehaviour
{
    [SerializeField] private Image questionDisplay;
    [SerializeField] private Material _hintMaterial;
    private AudioSource _hintselectsound;
    
    public void HighlightQuestionOnHint()
    {
        questionDisplay.material = _hintMaterial;
    }
    // Start is called before the first frame update
    void Start()
    {
        _hintselectsound= GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
