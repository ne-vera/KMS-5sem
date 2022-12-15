using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CurrencyChanger :  MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (StateVariables.canChangeCurrency)
        {
            animator.SetTrigger("ammeterRotate");
            StateVariables.is1A = true;
            StateVariables.canChangeCurrency = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
}
