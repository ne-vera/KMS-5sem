using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;

public class TableScript : MonoBehaviour
{
    [SerializeField]
    private TMP_Text message;

    [SerializeField]
    TMP_InputField textInput;

    [SerializeField]
    TMP_Text R;
    [SerializeField]
    TMP_Text C;
    
    GameObject FirstRow;
    GameObject SecondRow;
    GameObject ThirdRow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WriteValue()
    {
        // WriteCell(R);
        // StateVariables.step = 9;
        
        // WriteCell(C);
        // StateVariables.step = 11;
    }

    public void Clear()
    {
        // GameObject.FindGameObjectsWithTag("FieldsToInput");
        foreach(GameObject FieldsToInput in GameObject.FindGameObjectsWithTag("FieldsToInput"))
        {
            FieldsToInput.GetComponent<TMP_Text>().text = "-";
        }
    }

    void WriteCell(TMP_Text cell)
    {
        if (cell.text == "-")
        {
            cell.text = textInput.text.ToString();
        }
    }

    void ComputeH(TMP_Text X, TMP_Text H)
    {
        if(X.text != "-")
        {
            H.text = ((2900 * 100 * 0.5f * float.Parse(X.text)) / (2 * 3.14f * 7 * 9000)).ToString();
        } 
    }
    
    void ComputeB(TMP_Text Y, TMP_Text B)
    {
        if(Y.text != "-")
        {
            B.text = ((float.Parse(Y.text) * 9 * 4f) / (3 * 3)).ToString();
        } 
    }
    
}
