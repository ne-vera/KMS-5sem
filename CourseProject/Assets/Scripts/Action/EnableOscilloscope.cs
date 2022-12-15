using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnableOscilloscope : MonoBehaviour, IPointerClickHandler
{
    public GameObject OscilloscopeScreen;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (StateVariables.is1A)
        {
            gameObject.transform.rotation = Quaternion.Slerp(Quaternion.identity, Quaternion.Euler(40f, 0f, 0f), 0f);
        }
        StateVariables.isOscilloscopeEnabled = true;
        OscilloscopeScreen.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
        StateVariables.cycle = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
