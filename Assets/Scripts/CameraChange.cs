using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject thirdCam, firstCam;
    public int CamMode = 0;


    void Update()
    {
        if(Input.GetButtonDown("Camera"))
        {
            if(CamMode == 1)
            {
                CamMode = 0;
            }
        }
    }
}
