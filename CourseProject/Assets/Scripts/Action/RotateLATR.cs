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
        switch (StateVariables.step)
        {
            case 4:
                LATRanimator.SetTrigger("LATRRotate");
                StateVariables.step = 5;
                break;
            case 6:
                LATRanimator.SetTrigger("LATRDefault");
                ammeterAnimator.SetTrigger("Set6A");
                LATRPointerAnimator.SetTrigger("SetFirst");
                StateVariables.currency = 0.6f;
                StateVariables.step = 7;
                break;
            case 9:
                LATRanimator.SetTrigger("LATRRotate");
                ammeterAnimator.SetTrigger("Set0A");
                LATRPointerAnimator.SetTrigger("Set0");
                StateVariables.step = 10;
                StateVariables.currency = 0.1f;
                break;
            case 10:
                LATRanimator.SetTrigger("LATRRotate");
                ammeterAnimator.SetTrigger(AmmeterPoinerTrigger());
                LATRPointerAnimator.SetTrigger("SetFirst");
                StateVariables.step = 11;
                StateVariables.currency += 0.05f;
                break;
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

    string AmmeterPoinerTrigger()
    {
        switch (StateVariables.currency)
        {
            case 0.1f:
                return "Set1A";
            case 0.15f:
                return "Set15A";
            case 0.2f:
                return "Set2A";
            case 0.25f:
                return "Set25A";
            case 0.3f:
                return "Set3A";
            case 0.35f:
                return "Set35A";
            case 0.4f:
                return "Set4A";
            case 0.45f:
                return "Set45A";
            case 0.5f:
                return "Set5A";
            case 0.55f:
                return "Set55A";
            default:
                return "Set0A";
        }
    }
}
