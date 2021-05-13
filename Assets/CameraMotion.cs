using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 0.1f);
        }
        if (Input.GetKey(KeyCode.X))
        {
            Vector3 angle = transform.eulerAngles;
            angle.y += 1.0f;
            transform.eulerAngles = angle;
        }
        if (Input.GetKey(KeyCode.R))
        {
            Vector3 angle = transform.eulerAngles;
            angle.x -= 1.0f;
            transform.eulerAngles = angle;
        }
        if (Input.GetKey(KeyCode.T))
        {
            Camera camera = GetComponent<Camera>();
            camera.fieldOfView -= 1.0f;
        }
        if (Input.GetKey(KeyCode.G))
        {
            Camera camera = GetComponent<Camera>();
            camera.fieldOfView += 1.0f;
        }
    }
}
