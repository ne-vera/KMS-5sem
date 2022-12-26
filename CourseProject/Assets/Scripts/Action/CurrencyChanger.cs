using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CurrencyChanger :  MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (StateVariables.step == 1)
        {
            animator.SetTrigger("ammeterRotate");
            StateVariables.step = 2;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
}
