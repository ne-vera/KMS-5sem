using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Plugger : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (StateVariables.step == 5)
        {
            animator.SetTrigger("pluggable");
            StateVariables.step = 6;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
}
