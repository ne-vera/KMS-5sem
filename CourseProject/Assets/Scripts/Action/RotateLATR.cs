using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateLATR : MonoBehaviour,  IPointerClickHandler
{
    Animator LATRanimator;
    Animator ammeterAnimator;
    public GameObject ammeterPointer;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (StateVariables.is1A)
        {
            LATRanimator.SetTrigger("LATRRotate");
            StateVariables.isLATRZero = true;
        }
        if (StateVariables.isPlugged)
        {
            LATRanimator.SetTrigger("LATRDefault");
            ammeterAnimator.SetTrigger("Set6A");
            StateVariables.isCurrency = true;
            StateVariables.cycle = 2;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        LATRanimator = gameObject.GetComponent<Animator>();   
        ammeterAnimator = ammeterPointer.GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
