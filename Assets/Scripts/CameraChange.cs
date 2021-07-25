using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange: MonoBehaviour
{
    public GameObject thirdCam, firstCam;
    public int CamMode = 0;


    void Update()
    {
        if(Input.GetButtonDown("Camera"))
        {
            if (CamMode == 1)
            {
                CamMode = 0;
            } else {
                CamMode = 1;
            }

            StartCoroutine(CamChange());
        }
    }

    private IEnumerator CamChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            thirdCam.SetActive(true);
            firstCam.SetActive(false);
        }
        
        if(CamMode == 1)
        {
            thirdCam.SetActive(false);
            firstCam.SetActive(true);
        }
    }
}
