using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    /**
        * Author: Michelle Vuong
        * Description: Makes the UI face the camera.
        */
    void Update()
    {
        transform.LookAt(transform.position + Camera.main.transform.forward);
    }
}
