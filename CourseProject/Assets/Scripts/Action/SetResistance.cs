using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SetResistance : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if (StateVariables.step == 7)
        {
            animator.SetTrigger("SetResist");
            StateVariables.step = 8;
        }
    }
}
