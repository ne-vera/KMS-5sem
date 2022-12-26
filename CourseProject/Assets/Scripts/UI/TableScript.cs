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

    TMP_Text R;
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

    public void Clear()
    {
        // GameObject.FindGameObjectsWithTag("FieldsToInput");
        foreach(GameObject FieldsToInput in GameObject.FindGameObjectsWithTag("FieldsToInput"))
        {
            FieldsToInput.GetComponent<TMP_Text>().text = "-";
        }
    }
}
