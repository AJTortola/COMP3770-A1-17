using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIt : MonoBehaviour
{

    public float speed = 1.0f;
    public Vector3 Rotate = new Vector3(30, 60, 90);

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Rotate, speed);
    }
}
