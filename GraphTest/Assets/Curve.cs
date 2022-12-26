using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BansheeGz.BGSpline.Components;
using BansheeGz.BGSpline.Curve;

using UnityEngine.EventSystems;


public class Curve : MonoBehaviour
{
     public Camera maincamera;
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
        lineRenderer.startWidth = 0.01f;
        lineRenderer.endWidth = 0.01f;

        // Vector3 p0 = new Vector3(-3.093883f, 0.08185977f, 26.60277f);
        Vector3 p1 = new Vector3(-3.154724f, 0.2308939f,  26.60277f);
        // Vector3 p2 = new Vector3(-3.218645f, 0.2847095f, 26.60277f);
        Vector3 p3 = new Vector3(-3.18538f, 0.1774014f, 26.60277f);

    //0.6    
    Vector3 p0 = new Vector3(-3f, 0.093f, 26.6356f);
    // Vector3 p1 = new Vector3(-3.15f, 0.22f, 26.6356f);
    Vector3 p2 = new Vector3(-3.29f, 0.25f, 26.6356f);
    // Vector3 p3 = new Vector3(-3.15f, 0.13f, 26.60277f);
        Hysteresis(p0, p1, p2, p3);
        // Vector3 p0 = new Vector3(-3.149841f, 0.1808128f, 26.60277f);
        // Vector3 p0 = new Vector3(-3.18f, 0.2f, 26.60277f);
        // CreatePoint(p0);

       
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButton(0))
        {
            Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "OscilloscopeBtn5" || hit.collider.name == "OscilloscopeBtn6")
                {
                    MoveCurveHor(new Vector3(-3.1475f, 0.2f, 26.60277f));
                }
            }
        }  

        if (Input.GetMouseButton(0))
        {
            Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // while(transform.position < )
                if (hit.collider.name == "OscilloscopeBtn9")
                {
                    // transform.Translate(Vector3.right * 0.01f * Time.deltaTime);
                    // MoveCurveHor(new Vector3(-3.1475f, 0.18f, 26.60277f));
                    MovePointsVertically(0.01f);
                }
            }
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

    public void MoveCurveHor(Vector3 p0)
    {
        curve[0].PositionLocal = Vector3.Lerp(curve[0].PositionLocal, p0, 0.02f);
        curve[1].PositionLocal = Vector3.Lerp(curve[1].PositionLocal, p0, 0.02f);
        curve[2].PositionLocal = Vector3.Lerp(curve[2].PositionLocal, p0, 0.02f);
        curve[3].PositionLocal = Vector3.Lerp(curve[3].PositionLocal, p0, 0.02f);
    }

    public void TranslateCurve()
    {
        // curve[1].PositionLocal = Vector3.Lerp(curve[1].PositionLocal, p0, 0.02f);
        // curve[2].PositionLocal = Vector3.Lerp(curve[2].PositionLocal, p0, 0.02f);
        // curve[3].PositionLocal = Vector3.Lerp(curve[3].PositionLocal, p0, 0.02f);
        if (curve[0].PositionLocal.x < -3.1475f)
        {
            curve[0].PositionLocal  += new Vector3(0.01f * Time.deltaTime, 0, 0);
            curve[1].PositionLocal  += new Vector3(0.01f * Time.deltaTime, 0, 0);
            curve[2].PositionLocal  += new Vector3(0.01f * Time.deltaTime, 0, 0);
            curve[3].PositionLocal  += new Vector3(0.01f * Time.deltaTime, 0, 0);
        }
    }

    public void MovePointsVertically(float speed)
    {
        if (curve[0].PositionLocal.y > 0.18f)
        {
            curve[0].PositionLocal  -= new Vector3(0, speed * Time.deltaTime, 0);
            curve[1].PositionLocal  -= new Vector3(0, speed * Time.deltaTime, 0);
            curve[2].PositionLocal  -= new Vector3(0, speed * Time.deltaTime, 0);
            curve[3].PositionLocal  -= new Vector3(0, speed * Time.deltaTime, 0);
        }
    }
}
