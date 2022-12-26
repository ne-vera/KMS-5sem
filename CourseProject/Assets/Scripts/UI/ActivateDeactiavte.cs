using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactiavte : MonoBehaviour
{
    public GameObject Panel;
    bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick()
    {
        Debug.Log("here goes the click");
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
