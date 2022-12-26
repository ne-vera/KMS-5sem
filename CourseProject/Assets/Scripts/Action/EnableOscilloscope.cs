using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnableOscilloscope : MonoBehaviour, IPointerClickHandler
{
    public GameObject OscilloscopeScreen;
    public GameObject OscilloscopeLight;
    public Camera MainCamera;
    public GameObject CurveObj;

    public GameObject HorizontalBtn;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (StateVariables.step == 2)
        {
            gameObject.transform.rotation = Quaternion.Slerp(Quaternion.identity, Quaternion.Euler(40f, 0f, 0f), 0f);
        }
        StateVariables.step = 3;
        OscilloscopeScreen.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
        OscilloscopeLight.GetComponent<Renderer>().material.color = new Color(1, 0, 0);

        HorizontalBtn.AddComponent<CenterCurve>();
        HorizontalBtn.GetComponent<CenterCurve>().CurveObj = this.CurveObj;
        HorizontalBtn.GetComponent<CenterCurve>().MainCamera = this.MainCamera;
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
