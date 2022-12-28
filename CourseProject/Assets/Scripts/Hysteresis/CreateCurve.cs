using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BansheeGz.BGSpline.Components;
using BansheeGz.BGSpline.Curve;

public class CreateCurve : MonoBehaviour
{
    public Camera mainCamera;
    private BGCurve curve;
    private BGCcMath math;
    private BGCcVisualizationLineRenderer line;
    public LineRenderer lineRenderer;
    private bool isCurveEmpty = true;

    //0.6
    Vector3 p0 = new Vector3(-3.005f, 0.075f, 26.6356f);
    Vector3 p1 = new Vector3(-3.15f, 0.22f, 26.6356f);
    Vector3 p2 = new Vector3(-3.29f, 0.26f, 26.6356f);
    Vector3 p3 = new Vector3(-3.15f, 0.13f, 26.60277f);

    void Start()
    {

        curve = gameObject.AddComponent<BGCurve>();
        math = gameObject.AddComponent<BGCcMath>();
        line = gameObject.AddComponent<BGCcVisualizationLineRenderer>();
        line.UpdateAtStart = true;
        lineRenderer.startWidth = 0.015f;
        lineRenderer.endWidth = 0.015f;   
    }

    void FixedUpdate()
    {
        switch(StateVariables.step)
        {
            case 3:
                if(isCurveEmpty)
                {
                    Vector3 p0 = new Vector3(-3.18f, 0.2f, 26.60277f);
                    CreatePoints(p0);
                    isCurveEmpty = false; 
                }
                break;
            case 8:
                lineRenderer.startWidth = 0.005f;
                lineRenderer.endWidth = 0.005f; 
                HysteresisCurve(p0, curve[1].PositionLocal, p2, curve[3].PositionLocal, 0.01f);
                break;
            case 9:
                HysteresisCurve(p0, p1, p2, p3, 0.01f);
                break;
            case 10: 
                p0 = new Vector3(-3.15f, 0.17f, 26.60277f);
                HysteresisCurve(p0,p0,p0,p0, 0.01f);
                break;
            case 11:
                GetCoordinates(); 
                HysteresisCurve(p0, p1, p2, p3, 0.01f);
                break;
        }
    }

    public void CreatePoints(Vector3 p0)
    {
         curve.AddPoint(new BGCurvePoint(curve, p0, BGCurvePoint.ControlTypeEnum.BezierIndependant,
            new Vector3(0.01f, 0.01f, 0), new Vector3(-0.01f, 0.01f, 0)));
        curve.AddPoint(new BGCurvePoint(curve, p0, BGCurvePoint.ControlTypeEnum.BezierIndependant,
            new Vector3(0.01f, 0.01f, 0), new Vector3(-0.01f, 0.01f, 0)));
        curve.AddPoint(new BGCurvePoint(curve, p0, BGCurvePoint.ControlTypeEnum.BezierIndependant,
            new Vector3(0.01f, 0.01f, 0), new Vector3(-0.01f, 0.01f, 0)));
        curve.AddPoint(new BGCurvePoint(curve, p0, BGCurvePoint.ControlTypeEnum.BezierIndependant,
            new Vector3(0.01f, 0.01f, 0), new Vector3(-0.01f, 0.01f, 0)));
        curve.Closed = true;
    }

    public void HysteresisCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float control)
    {
        curve[0].ControlFirstLocal = new Vector3(-control, -control, 0);
        curve[0].ControlSecondLocal = new Vector3(-control,- control, 0);
        curve[1].ControlFirstLocal = new Vector3(control, control, 0);
        curve[1].ControlSecondLocal = new Vector3(control, control, 0);
        curve[2].ControlFirstLocal = new Vector3(control, control, 0);
        curve[2].ControlSecondLocal = new Vector3(control, control, 0);
        curve[3].ControlFirstLocal = new Vector3(-control, control, 0);
        curve[3].ControlSecondLocal = new Vector3(-control, control, 0);
        
        curve[0].PositionLocal = Vector3.Lerp(curve[0].PositionLocal, p0, 0.02f);
        curve[1].PositionLocal = Vector3.Lerp(curve[1].PositionLocal, p1, 0.02f);
        curve[2].PositionLocal = Vector3.Lerp(curve[2].PositionLocal, p2, 0.02f);
        curve[3].PositionLocal = Vector3.Lerp(curve[3].PositionLocal, p3, 0.02f); 
    }

    public void GetCoordinates()
    { 
        Debug.Log((StateVariables.currency - 0.05f).ToString());
        switch((StateVariables.currency - 0.05f).ToString())
        {
            case "0,1":
                Debug.Log("i am here");
                p0 = new Vector3(-3.125f, 0.14f, 26.60234f);
                p1 = new Vector3(-3.142f, 0.18f, 26.603f);
                p2 = new Vector3(-3.18f, 0.22f, 26.60234f);
                p3 = new Vector3(-3.16f, 0.168f, 26.60234f); 
                break;
            case "0,15":
                p0 = new Vector3(-3.11f, 0.13f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.20f, 26.603f);
                p2 = new Vector3(-3.19f, 0.22f, 26.60234f);
                p3 = new Vector3(-3.16f, 0.168f, 26.60234f);
                break;
            case "0,2":
                p0 = new Vector3(-3.1f, 0.13f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.19f, 26.603f);
                p2 = new Vector3(-3.205f, 0.22f, 26.60234f);
                p3 = new Vector3(-3.16f, 0.168f, 26.60234f); 
                break;
            case "0,25":
                p0 = new Vector3(-3.09f, 0.125f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.2f, 26.603f);
                p2 = new Vector3(-3.21f, 0.23f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.155f, 26.60234f);
                break;
            case "0,3":
                p0 = new Vector3(-3.067f, 0.115f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.22f, 26.603f);
                p2 = new Vector3(-3.23f, 0.24f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.135f, 26.60234f);
                break;
            case "0,35":
                p0 = new Vector3(-3.06f, 0.11f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.22f, 26.603f);
                p2 = new Vector3(-3.237f, 0.245f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.135f, 26.60234f);
                break;
            case "0,4":
                p0 = new Vector3(-3.05f, 0.105f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.22f, 26.603f);
                p2 = new Vector3(-3.247f, 0.25f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.135f, 26.60234f);
                break;
            case "0,45":
                p0 = new Vector3(-3.035f, 0.105f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.22f, 26.603f);
                p2 = new Vector3(-3.262f, 0.25f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.135f, 26.60234f);
                break;
            case "0,50":
                p0 = new Vector3(-3.03f, 0.105f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.22f, 26.603f);
                p2 = new Vector3(-3.267f, 0.255f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.13f, 26.60234f);
                break;
            case "0,55":
                p0 = new Vector3(-3.015f, 0.10f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.22f, 26.603f);
                p2 = new Vector3(-3.282f, 0.26f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.13f, 26.60234f); 
                break;
            case "0,6":
                p0 = new Vector3(-3.005f, 0.075f, 26.6356f);
                p1 = new Vector3(-3.15f, 0.22f, 26.6356f);
                p2 = new Vector3(-3.29f, 0.26f, 26.6356f);
                p3 = new Vector3(-3.15f, 0.13f, 26.60277f);
                break;
            default :
                Debug.Log("Error");
                break;
        }
    }
}
