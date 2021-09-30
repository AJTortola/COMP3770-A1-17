using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeIt : MonoBehaviour
{

    float minScale = 1; // Minimum scale value
    float maxScale = 4; // Maximum scale value
    


    void Update()
    {

        float scale = Mathf.PingPong(Time.time, maxScale - minScale) + minScale;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}

