using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 pointA = new Vector3(32, 1, -4);
    Vector3 pointB = new Vector3(32, 1, -9);

    private void Update()
    {
        transform.position = Vector3.Lerp(pointA,pointB,Mathf.PingPong(Time.time, 1));
    }
}

 