using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YCellScript : MonoBehaviour
{
    public TMP_Text B;
    // Start is called before the first frame update
    void Start()
    {
        TMP_InputField inputField = gameObject.GetComponent<TMP_InputField>();
        inputField.onValueChanged.AddListener(delegate { ComputeB(inputField.text, B); });    
    }

    void ComputeB(string Y, TMP_Text B)
    {
        try
        {
            if (Y != "-")
            {
                B.text = ((float.Parse(Y) * 9 * 4f) / (3 * 3)).ToString();
            } 
        }
        catch
        {
            B.text = "-";
        }
    }

    void Update()
    {
        if (StateVariables.step == 11)
        {
            if (B.text != "-")
            {
                StateVariables.isYWriten = true;
            }
        }
    }
}
