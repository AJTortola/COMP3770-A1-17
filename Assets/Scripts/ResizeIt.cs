using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeIt : MonoBehaviour
{
    public float speed = 1.0f; 
    public Vector3 scaleChange = new Vector3(4, 4, 4);

    void Update()
    {

        transform.localScale += scaleChange;
        

    }

}
