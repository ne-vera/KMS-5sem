using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class XCellScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text H;
    void Start()
    {
        TMP_InputField inputField = gameObject.GetComponent<TMP_InputField>();
        inputField.onValueChanged.AddListener(delegate { ComputeH(inputField.text, H); });     
    }
    void ComputeH(string X, TMP_Text H)
    {
        try
        {
            if(X != "")
            {
                H.text = ((2900 * 100 * 0.5f * float.Parse(X)) / (2 * 3.14f * 7 * 9000)).ToString();
            } 
        }
        catch
        {
            H.text = "-";
        }
    }

    void Update()
    {
        if (StateVariables.step == 11)
        {
            if (H.text != "-")
            {
                StateVariables.isXWriten = true;
            }

            if (StateVariables.isXWriten && StateVariables.isYWriten)
            {
                if (StateVariables.currency <= 0.6f)
                {
                    StateVariables.step = 10;
                }
                else
                    StateVariables.step = 12;
            }
        }
    }
}
