using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class TopDwonCameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float xAngle = 45;
    [SerializeField] private float distance = 10;

    private void LateUpdate()
    {
        if (target == null) return;
        transform.rotation = Quaternion.Euler(xAngle, 0, 0);
        transform.position = target.position - transform.forward * distance;
    }
}
