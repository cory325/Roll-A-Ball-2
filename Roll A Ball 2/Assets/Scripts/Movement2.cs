using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    Vector3 pointA = new Vector3(43, 1, 3);
    Vector3 pointB = new Vector3(46, 1, 3);

    private void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
