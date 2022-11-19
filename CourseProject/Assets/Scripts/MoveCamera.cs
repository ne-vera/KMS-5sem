using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    Transform target;
    float scrollSpeed = 5f;    // скорость вращения и передвижения камеры
    int rotationSensivity = 7;
    int maxDistance = 15;
    int minDistance = 1;
 
    void Start()
    {
        transform.LookAt(target);
    }

    void Update()
    {
        // Движение камеры влево-право, вниз-вверх ADSW.
        if (!Input.GetMouseButton(1))
        {
            float x = Input.GetAxis("Horizontal"); 
            float y = Input.GetAxis("Vertical"); 
            if (x != 0 || y != 0)
            {
                Vector3 newPos = transform.position + (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / rotationSensivity;
                if (ControlDistance(Vector3.Distance(newPos, target.position))) 
                {
                    transform.position = newPos;
                }
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
}