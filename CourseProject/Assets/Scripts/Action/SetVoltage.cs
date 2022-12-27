using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SetVoltage : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        
        if (StateVariables.step == 9)
        {
            animator.SetTrigger("SetVoltage");
            StateVariables.step = 10;
        }
    }
}
