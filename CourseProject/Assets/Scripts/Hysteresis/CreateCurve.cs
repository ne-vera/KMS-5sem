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
    // Vector3 p0 = new Vector3(-2.947589f, 0.06620646f, 26.57729f);
    // Vector3 p1 = new Vector3(-3.157973f, 0.2513646f, 26.57729f);
    // Vector3 p2 = new Vector3(-3.356328f, 0.322132f, 26.56358f);
    // Vector3 p3 = new Vector3(-3.18538f, 0.1774014f, 26.60277f);

    // Start is called before the first frame update
    //0.1
    Vector3 p0 = new Vector3(-3.093883f, 0.08185977f, 26.60277f);
    Vector3 p1 = new Vector3(-3.154724f, 0.2308939f,  26.60277f);
    Vector3 p2 = new Vector3(-3.218645f, 0.2847095f, 26.60277f);
    Vector3 p3 = new Vector3(-3.18538f, 0.1774014f, 26.60277f);

    void Start()
    {
        curve = gameObject.AddComponent<BGCurve>();
         // add math solver
        math = gameObject.AddComponent<BGCcMath>();
        line = gameObject.AddComponent<BGCcVisualizationLineRenderer>();
        line.UpdateAtStart = true;
        lineRenderer.startWidth = 0.015f;
        lineRenderer.endWidth = 0.015f;   
    }

    void FixedUpdate()
    {
        if (StateVariables.step == 3 && isCurveEmpty)
        {
            Vector3 p0 = new Vector3(-3.18f, 0.2f, 26.60277f);
            CreatePoints(p0);
            isCurveEmpty = false; 
        }

        if (StateVariables.step == 8)
        {
            HysteresisCurve(p0, curve[1].PositionLocal, p2, curve[3].PositionLocal, 0.01f);
        }
    }

    // Update is called once per frame
    void Update()
    {   
        // if (StateVariables.cycle == 2)
        // {
        //     lineRenderer.startWidth = 0.005f;
        //     lineRenderer.endWidth = 0.005f;

        //     HysteresisCurve(p0, curve[1].PositionLocal, p2, curve[3].PositionLocal, 0.01f);
        // }
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
}
