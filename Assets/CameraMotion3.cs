using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion3 : MonoBehaviour
{
    Vector3 posA;
    Vector3 posB;
    Vector3 angleA;
    Vector3 angleB;
    //float fovA;
    //float fovB;
    // Start is called before the first frame update
    void Start()
    {
        posA.Set(0, 0, -5); // カメラ地点A
        posB.Set(0, 0, -3); // カメラ地点B
        angleA.Set(0, 0, 0);
        angleB.Set(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            // カメラを視点Aに
            transform.position = posA;
            transform.eulerAngles = angleA;
            // Camera.main.fieldOfView = fovA;
        }
        else if (Input.GetKey(KeyCode.B))
        {
            // カメラを視点Bに
            transform.position = posB;
            transform.eulerAngles = angleB;
            // Camera.main.fieldOfView = fovB;
        }
    }
}
