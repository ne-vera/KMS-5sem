using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateLATR : MonoBehaviour,  IPointerClickHandler
{
    Animator LATRanimator;
    Animator ammeterAnimator;

    Animator LATRPointerAnimator;
    public GameObject ammeterPointer;
    public GameObject LATRPointer;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (StateVariables.step == 4)
        {
            LATRanimator.SetTrigger("LATRRotate");
            StateVariables.step = 5;
        }
        
        if (StateVariables.step == 6)
        {
            LATRanimator.SetTrigger("LATRDefault");
            ammeterAnimator.SetTrigger("Set6A");
            LATRPointerAnimator.SetTrigger("SetFirst");
            StateVariables.currency = 0.6f;
            StateVariables.step = 7;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        LATRanimator = gameObject.GetComponent<Animator>();  
        LATRPointerAnimator = LATRPointer.GetComponent<Animator>();  
        ammeterAnimator = ammeterPointer.GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
