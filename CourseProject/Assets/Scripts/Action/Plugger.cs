using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Plugger : MonoBehaviour, IPointerClickHandler
{
    Animator animator;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (StateVariables.isLATRZero)
        {
            animator.SetTrigger("pluggable");
            StateVariables.isPlugged = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
