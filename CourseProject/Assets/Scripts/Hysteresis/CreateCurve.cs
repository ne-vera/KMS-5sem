using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BansheeGz.BGSpline.Components;
using BansheeGz.BGSpline.Curve;

public class CreateCurve : MonoBehaviour
{
    private BGCurve curve;
    private BGCcMath math;
    private BGCcVisualizationLineRenderer line;
    public LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        curve = gameObject.AddComponent<BGCurve>();
         // add math solver
        math = gameObject.AddComponent<BGCcMath>();
        line = gameObject.AddComponent<BGCcVisualizationLineRenderer>();
        line.UpdateAtStart = true;
        lineRenderer.startWidth = 0.015f;
        lineRenderer.endWidth = 0.015f;
        // line.SplitMode = BGCcVisualizationLineRenderer.

        // //print calculated values
        // print("Spline's Length=" + math.GetDistance());
        // print("Position at the middle=" + math.CalcByDistanceRatio(BGCurveBaseMath.Field.Position, .5f));
        // print("Point, closest to Vector3.one, =" + math.CalcPositionByClosestPoint(Vector3.one));\
        // Vector3 p0 = new Vector3(-3.093883f, 0.08185977f, 26.60277f);
        // Vector3 p1 = new Vector3(-3.154724f, 0.2308939f,  26.60277f);
        // Vector3 p2 = new Vector3(-3.218645f, 0.2847095f, 26.60277f);
        // Vector3 p3 = new Vector3(-3.18538f, 0.1774014f, 26.60277f);
        // Hysteresis(p0, p1, p2, p3);
       
    }

    void FixedUpdate()
    {
        if (StateVariables.cycle == 1)
        {
            Vector3 p0 = new Vector3(-3.18f, 0.179f, 26.60277f);
            CreatePoint(p0);
            StateVariables.cycle = 0;  
        }
    }

    // Update is called once per frame
    void Update()
    {
    
        if (StateVariables.cycle == 2)
        {
            // Vector3 p0 = new Vector3(-3.093883f, 0.08185977f, 26.60277f);
            // Vector3 p1 = new Vector3(-3.154724f, 0.2308939f,  26.60277f);
            // Vector3 p2 = new Vector3(-3.218645f, 0.2847095f, 26.60277f);
            // Vector3 p3 = new Vector3(-3.18538f, 0.1774014f, 26.60277f);
            // Hysteresis(p0, p1, p2, p3);
            lineRenderer.startWidth = 0.005f;
            lineRenderer.endWidth = 0.005f;
            curve[0].ControlFirstLocal = new Vector3(-0.01f, -0.01f, 0);
            curve[0].ControlSecondLocal = new Vector3(-0.01f,- 0.01f, 0);

            curve[1].ControlFirstLocal = new Vector3(0.01f, 0.01f, 0);
            curve[1].ControlSecondLocal = new Vector3(0.01f, 0.01f, 0);

            curve[2].ControlFirstLocal = new Vector3(0.01f, 0.01f, 0);
            curve[2].ControlSecondLocal = new Vector3(0.01f, 0.01f, 0);

            curve[3].ControlFirstLocal = new Vector3(-0.01f, 0.01f, 0);
            curve[3].ControlSecondLocal = new Vector3(-0.01f, 0.01f, 0);
            
            curve[0].PositionLocal = Vector3.Lerp(curve[0].PositionLocal, new Vector3(-3.093883f, 0.08185977f, 26.60277f), 0.02f);
            curve[1].PositionLocal = Vector3.Lerp(curve[1].PositionLocal, new Vector3(-3.154724f, 0.2308939f,  26.60277f), 0.02f);
            curve[2].PositionLocal = Vector3.Lerp(curve[2].PositionLocal, new Vector3(-3.218645f, 0.2847095f, 26.60277f), 0.02f);
            curve[3].PositionLocal = Vector3.Lerp(curve[3].PositionLocal, new Vector3(-3.18538f, 0.1774014f, 26.60277f), 0.02f);
        }
    }

    public void Hysteresis(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
    {
        curve.AddPoint(new BGCurvePoint(curve, p0, BGCurvePoint.ControlTypeEnum.BezierIndependant,
            new Vector3(-0.01f, -0.01f, 0), new Vector3(-0.01f,- 0.01f, 0)));
        curve.AddPoint(new BGCurvePoint(curve, p1, BGCurvePoint.ControlTypeEnum.BezierIndependant,
            new Vector3(0.01f, 0.01f, 0), new Vector3(0.01f, 0.01f, 0)));
        curve.AddPoint(new BGCurvePoint(curve, p2, BGCurvePoint.ControlTypeEnum.BezierIndependant,
            new Vector3(0.01f, 0.01f, 0), new Vector3(0.01f, 0.01f, 0)));
        curve.AddPoint(new BGCurvePoint(curve, p3, BGCurvePoint.ControlTypeEnum.BezierIndependant,
            new Vector3(-0.01f, 0.01f, 0), new Vector3(-0.01f, 0.01f, 0)));
        curve.Closed = true;
    }

    public void CreatePoint(Vector3 p0)
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
}
