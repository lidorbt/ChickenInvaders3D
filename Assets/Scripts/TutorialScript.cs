using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    void Update()
    {
        if(Time.realtimeSinceStartup >= 5)
        {
            gameObject.SetActive(false);
        }
    }
}
