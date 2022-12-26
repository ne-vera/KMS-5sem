using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BansheeGz.BGSpline.Components;
using BansheeGz.BGSpline.Curve;

public class CenterCurve : MonoBehaviour
{
    public Camera MainCamera;
    private BGCurve curve;   
    public GameObject CurveObj;

    private GameObject BtnHorizontal;
    private GameObject BtnHorizontalSignificant;
    private GameObject BtnVertical; 

    private bool isHorizontallyCentralized = false;
    private bool isVerticallyCentralized = false;
    // Start is called before the first frame update
    void Start()
    {
        curve = CurveObj.GetComponent<BGCurve>();
        BtnVertical = GameObject.Find("OscilloscopeBtnVertical");
        BtnHorizontal = GameObject.Find("OscilloscopeBtnHorzintal");
        BtnHorizontalSignificant = GameObject.Find("OscilloscopeBtnHorizontalSignificant");
    }

    // Update is called once per frame
    void Update()
    {
        if (StateVariables.step == 3)
        {
            if (Input.GetMouseButton(0))
            {
                Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    switch(hit.collider.name)
                    {
                        case "OscilloscopeBtnHorzintal":
                            MovePointsHorizontally(0.01f, BtnHorizontal);
                            break;
                        case "OscilloscopeBtnHorizontalSignificant":
                            MovePointsHorizontally(0.05f, BtnHorizontalSignificant);
                            break;
                        case "OscilloscopeBtnVertical":
                            MovePointsVertically(0.01f, BtnVertical);     
                            break;
                    }
                }
            }
            if (isHorizontallyCentralized && isVerticallyCentralized)
            {
                StateVariables.step = 4;
            }
        }   
    }

    public void MovePointsHorizontally(float speed, GameObject gameObject)
    {
        if (curve[0].PositionLocal.x < -3.15f)
        {
            gameObject.transform.rotation *= Quaternion.Euler(0f, 0f, 50f*Time.deltaTime);
            curve[0].PositionLocal  += new Vector3(speed * Time.deltaTime, 0, 0);
            curve[1].PositionLocal  += new Vector3(speed * Time.deltaTime, 0, 0);
            curve[2].PositionLocal  += new Vector3(speed * Time.deltaTime, 0, 0);
            curve[3].PositionLocal  += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else
        {
            isHorizontallyCentralized = true;
        }
    }

    public void MovePointsVertically(float speed, GameObject gameObject)
    {
        if (curve[0].PositionLocal.y > 0.17f)
        {
            gameObject.transform.rotation *= Quaternion.Euler(0f, 0f, 50f*Time.deltaTime);
            curve[0].PositionLocal  -= new Vector3(0, speed * Time.deltaTime, 0);
            curve[1].PositionLocal  -= new Vector3(0, speed * Time.deltaTime, 0);
            curve[2].PositionLocal  -= new Vector3(0, speed * Time.deltaTime, 0);
            curve[3].PositionLocal  -= new Vector3(0, speed * Time.deltaTime, 0);
        }
        else
        {
            isVerticallyCentralized = true;
        }
    }
}
