using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;

public class TableScript : MonoBehaviour
{
    public void Clear()
    {
        if (GameObject.FindGameObjectsWithTag("FieldsToInput").Length > 0)
        {
            foreach(GameObject fieldsToInput in GameObject.FindGameObjectsWithTag("FieldsToInput"))
            {
                if (fieldsToInput.GetComponent<TMP_InputField>() != null)
                {
                    fieldsToInput.GetComponent<TMP_InputField>().text = "";
                }
            }
        }
        
    }
  
}
