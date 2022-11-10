using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextSelection : MonoBehaviour
{
    
    [SerializeField] private Canvas sentenceCanvas;
    [SerializeField] private new Canvas audio;
    [SerializeField] private Canvas welcomeCanvas;
    [SerializeField] private Canvas context;
    [SerializeField] private Canvas detail;
    [SerializeField] private Canvas option1;
    [SerializeField] private Canvas option2;
    [SerializeField] private Canvas option3;
    [SerializeField] private Canvas option4;
    [SerializeField] private Canvas option5;
    [SerializeField] private Canvas option6;
    // Start is called before the first frame update

    public void StartContextRoutine()
    {
        option1.enabled = true;
        option2.enabled = true;
        option3.enabled = true;
        option4.enabled = true;
        option5.enabled = true;
        option6.enabled = true;
        welcomeCanvas.enabled = false;
        sentenceCanvas.enabled = true;
        context.enabled = false;
        detail.enabled = false;
        audio.enabled = true;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
