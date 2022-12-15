using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
   [SerializeField]
    Transform target;
    float scrollSpeed = 5f;    // скорость вращения и передвижения камеры
    int rotationSensivity = 7;
    int maxDistance = 10;
    int minDistance = 1;
 
    void Start()
    {
        transform.LookAt(target);
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    void FixedUpdate()
    {
        // Движение камеры влево-право, вниз-вверх ADSW.
        if (!Input.GetMouseButton(1))
        {
            float x = Input.GetAxis("Horizontal"); 
            float y = Input.GetAxis("Vertical"); 
            if (x != 0 || y != 0)
            {
            Vector3 newPos = transform.position + (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / rotationSensivity;
            if (ControlDistance(Vector3.Distance(newPos, target.position))) transform.position = newPos;
            }
        }
        // Приближение камеры колёсиком мыши.
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            Vector3 newPos = transform.position + transform.TransformDirection(Vector3.forward 
            * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
            if (ControlDistance(Vector3.Distance(newPos, target.position))) transform.position = newPos;
        }

        // Вращение вокруг установки.
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X") * scrollSpeed);
        }

        if (move)
        {
            offset += speed;
            transform.position = Vector3.Lerp(startPosition, needPosition, offset);
            transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);
            if (offset >= 1)
            {
                move = false;
                offset = 0;
            }
        }
    }

    // Функция ограничения пределов движения камеры.
    bool ControlDistance (float distance)
    {
        if (distance > minDistance && distance < maxDistance) 
        {
            return true;
        }
        return false;
    }

    #region Приближение камеры к объекту
     Vector3 startPosition;
    Vector3 needPosition;
    bool move = false;
    float speed = 0.01f;
    float offset = 0;
    Quaternion startRotation;
    Quaternion needRotaton;

    public void ZoomLATR()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(3.898211f, 0.7f, 29f);
            needRotaton = Quaternion.Euler(20f, -180f, 0f);
        }
    }

    public void ZoomAmmeter()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(3.110283f, 0.3f, 27.00826f);
            needRotaton = Quaternion.Euler(90f, -180f, 0f);
        }
    }

    public void ZoomCapacitor()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-1.016491f, -0.4371765f, 28.28f);
            needRotaton = Quaternion.Euler(0f, -180f, 0f);
        }
    }

    public void ZoomOscilloscope()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-3.2f, -0f, 28f);
            needRotaton = Quaternion.Euler(0f, -180f, 0f);
        }
    }

    public void ZoomResistBox()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(0.9348078f, 1f, 26.8f);
            needRotaton = Quaternion.Euler(90f, -180f, 0f);
        }
    }

    public void ZoomTorus()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(2.023064f, 0.3f, 26.69924f);
            needRotaton = Quaternion.Euler(90f, -180f, 0f);
        }
    }
    #endregion


    public void SetDefault()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(0.8444268f, 0.3f, 33.87f);
            needRotaton = Quaternion.Euler(0, 180, 0);
        }
    }
}
