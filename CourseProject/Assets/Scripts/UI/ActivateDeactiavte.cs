using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactiavte : MonoBehaviour
{
    public GameObject Panel;
    bool isActive = false;

    public void OnPointerClick()
    {
        if (isActive)
        {
            Panel.SetActive(false);
            isActive = false;;
        }
        else
        {
            Panel.SetActive(true);
            isActive = true;
        }
    }
}
