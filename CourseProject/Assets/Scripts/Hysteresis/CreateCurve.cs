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
    // Vector3 p0, p1, p2, p3;
 

    //0.10
    // Vector3 p0 = new Vector3(-3.129f, 0.13f, 26.603f);
    // Vector3 p1 = new Vector3(-3.142f, 0.18f, 26.603f);
    // Vector3 p2 = new Vector3(-3.18f, 0.22f, 26.603f);
    // Vector3 p3 = new Vector3(-3.165f, 0.168f, 26.603f); 
    //0.15
    // Vector3 p0 = new Vector3(-3.11f, 0.13f, 26.60234f);
    // Vector3 p1 = new Vector3(-3.15f, 0.20f, 26.603f);
    // Vector3 p2 = new Vector3(-3.19f, 0.22f, 26.60234f);
    // Vector3 p3 = new Vector3(-3.16f, 0.168f, 26.60234f);
    //0.20
    // Vector3 p0 = new Vector3(-3.1f, 0.13f, 26.60234f);
    // Vector3 p1 = new Vector3(-3.15f, 0.19f, 26.603f);
    // Vector3 p2 = new Vector3(-3.205f, 0.22f, 26.60234f);
    // Vector3 p3 = new Vector3(-3.16f, 0.168f, 26.60234f);
    //0.25
    // Vector3 p0 = new Vector3(-3.09f, 0.125f, 26.60234f);
    // Vector3 p1 = new Vector3(-3.15f, 0.2f, 26.603f);
    // Vector3 p2 = new Vector3(-3.21f, 0.23f, 26.60234f);
    // Vector3 p3 = new Vector3(-3.15f, 0.155f, 26.60234f);
    
    //0.30
    // Vector3 p0 = new Vector3(-3.067f, 0.115f, 26.60234f);
    // Vector3 p1 = new Vector3(-3.15f, 0.22f, 26.603f);
    // Vector3 p2 = new Vector3(-3.23f, 0.24f, 26.60234f);
    // Vector3 p3 = new Vector3(-3.15f, 0.135f, 26.60234f);
    //0.35
    // Vector3 p0 = new Vector3(-3.06f, 0.11f, 26.60234f);
    // Vector3 p1 = new Vector3(-3.15f, 0.22f, 26.603f);
    // Vector3 p2 = new Vector3(-3.237f, 0.245f, 26.60234f);
    // Vector3 p3 = new Vector3(-3.15f, 0.135f, 26.60234f);
    //0.40
    // Vector3 p0 = new Vector3(-3.05f, 0.105f, 26.60234f);
    // Vector3 p1 = new Vector3(-3.15f, 0.22f, 26.603f);
    // Vector3 p2 = new Vector3(-3.247f, 0.25f, 26.60234f);
    // Vector3 p3 = new Vector3(-3.15f, 0.135f, 26.60234f);
    //0.45
    // Vector3 p0 = new Vector3(-3.035f, 0.105f, 26.60234f);
    // Vector3 p1 = new Vector3(-3.15f, 0.22f, 26.603f);
    // Vector3 p2 = new Vector3(-3.262f, 0.25f, 26.60234f);
    // Vector3 p3 = new Vector3(-3.15f, 0.135f, 26.60234f);
    //0.50
    // Vector3 p0 = new Vector3(-3.03f, 0.105f, 26.60234f);
    // Vector3 p1 = new Vector3(-3.15f, 0.22f, 26.603f);
    // Vector3 p2 = new Vector3(-3.267f, 0.255f, 26.60234f);
    // Vector3 p3 = new Vector3(-3.15f, 0.13f, 26.60234f);
    //0.55
    // Vector3 p0 = new Vector3(-3.015f, 0.10f, 26.60234f);
    // Vector3 p1 = new Vector3(-3.15f, 0.22f, 26.603f);
    // Vector3 p2 = new Vector3(-3.282f, 0.26f, 26.60234f);
    // Vector3 p3 = new Vector3(-3.15f, 0.13f, 26.60234f);

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
        // lineRenderer.startWidth = 0.005f;
        // lineRenderer.endWidth = 0.005f; 
        // Create(p0, p1, p2, p3);
    }

    void FixedUpdate()
    {
        // GetCoordinates(p0, p1, p2, p3);
        if (StateVariables.step == 3 && isCurveEmpty)
        {
            Vector3 p0 = new Vector3(-3.18f, 0.2f, 26.60277f);
            CreatePoints(p0);
            isCurveEmpty = false; 
        }

        if (StateVariables.step == 8)
        {
            lineRenderer.startWidth = 0.005f;
            lineRenderer.endWidth = 0.005f; 
            HysteresisCurve(p0, curve[1].PositionLocal, p2, curve[3].PositionLocal, 0.01f);
            // HysteresisCurve(p0, p1, p2, p3, 0.01f);
        }

        if (StateVariables.step == 10)
        {
            HysteresisCurve(p0, p1, p2, p3, 0.01f);
        }

        GetCoordinates(p0, p1, p2, p3);
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

    // public void Create(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
    // {
    //     curve.AddPoint(new BGCurvePoint(curve, p0, BGCurvePoint.ControlTypeEnum.BezierIndependant,
    //         new Vector3(-0.01f, -0.01f, 0), new Vector3(-0.01f,- 0.01f, 0)));
    //     curve.AddPoint(new BGCurvePoint(curve, p1, BGCurvePoint.ControlTypeEnum.BezierIndependant,
    //         new Vector3(0.01f, 0.01f, 0), new Vector3(0.01f, 0.01f, 0)));
    //     curve.AddPoint(new BGCurvePoint(curve, p2, BGCurvePoint.ControlTypeEnum.BezierIndependant,
    //         new Vector3(0.01f, 0.01f, 0), new Vector3(0.01f, 0.01f, 0)));
    //     curve.AddPoint(new BGCurvePoint(curve, p3, BGCurvePoint.ControlTypeEnum.BezierIndependant,
    //         new Vector3(-0.01f, 0.01f, 0), new Vector3(-0.01f, 0.009900138f, 0)));
    //     curve.Closed = true;
    // }

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

    public void GetCoordinates(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
    {
        switch(StateVariables.currency)
        {
            case 0.1f:
                p0 = new Vector3(-3.093883f, 0.08185977f, 26.60277f);
                p1 = new Vector3(-3.154724f, 0.2308939f,  26.60277f);
                p2 = new Vector3(-3.218645f, 0.2847095f, 26.60277f);
                p3 = new Vector3(-3.18538f, 0.1774014f, 26.60277f);
                break;
            case 0.15f:
                p0 = new Vector3(-3.11f, 0.13f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.20f, 26.603f);
                p2 = new Vector3(-3.19f, 0.22f, 26.60234f);
                p3 = new Vector3(-3.16f, 0.168f, 26.60234f);
                break;
            case 0.20f:
                p0 = new Vector3(-3.1f, 0.13f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.19f, 26.603f);
                p2 = new Vector3(-3.205f, 0.22f, 26.60234f);
                p3 = new Vector3(-3.16f, 0.168f, 26.60234f); 
                break;
            case 0.25f:
                p0 = new Vector3(-3.09f, 0.125f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.2f, 26.603f);
                p2 = new Vector3(-3.21f, 0.23f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.155f, 26.60234f);
                break;
            case 0.30f:
                p0 = new Vector3(-3.067f, 0.115f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.22f, 26.603f);
                p2 = new Vector3(-3.23f, 0.24f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.135f, 26.60234f);
                break;
            case 0.35f:
                p0 = new Vector3(-3.06f, 0.11f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.22f, 26.603f);
                p2 = new Vector3(-3.237f, 0.245f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.135f, 26.60234f);
                break;
            case 0.40f:
                p0 = new Vector3(-3.05f, 0.105f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.22f, 26.603f);
                p2 = new Vector3(-3.247f, 0.25f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.135f, 26.60234f);
                break;
            case 0.45f:
                p0 = new Vector3(-3.035f, 0.105f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.22f, 26.603f);
                p2 = new Vector3(-3.262f, 0.25f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.135f, 26.60234f);
                break;
            case 0.50f:
                p0 = new Vector3(-3.03f, 0.105f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.22f, 26.603f);
                p2 = new Vector3(-3.267f, 0.255f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.13f, 26.60234f);
                break;
            case 0.55f:
                p0 = new Vector3(-3.015f, 0.10f, 26.60234f);
                p1 = new Vector3(-3.15f, 0.22f, 26.603f);
                p2 = new Vector3(-3.282f, 0.26f, 26.60234f);
                p3 = new Vector3(-3.15f, 0.13f, 26.60234f); 
                break;
            case 0.60f:
                p0 = new Vector3(-3.005f, 0.075f, 26.6356f);
                p1 = new Vector3(-3.15f, 0.22f, 26.6356f);
                p2 = new Vector3(-3.29f, 0.26f, 26.6356f);
                p3 = new Vector3(-3.15f, 0.13f, 26.60277f);
                break;
        }
    }
}
