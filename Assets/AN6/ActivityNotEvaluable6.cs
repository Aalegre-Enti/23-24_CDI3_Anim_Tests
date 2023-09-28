using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityNotEvaluable6 : MonoBehaviour
{
    public Transform target;
    private void Update()
    {
        Vector3 axisX = Vector3.Cross(transform.right, target.right).normalized;
        float angleX = -Mathf.Acos(Vector3.Dot(transform.right, target.right)) * Mathf.Rad2Deg;
        target.Rotate(axisX, angleX, Space.World);

        Vector3 axisY = Vector3.Cross(transform.up, target.up).normalized;
        float angleY = -Mathf.Acos(Vector3.Dot(transform.up, target.up)) * Mathf.Rad2Deg;
        target.Rotate(axisY, angleY, Space.World);
    }





























    void Sol()
    {
        Vector3 axisX = Vector3.Cross(transform.right, target.right).normalized;
        float angleX = -Mathf.Acos(Vector3.Dot(transform.right, target.right)) * Mathf.Rad2Deg;
        target.Rotate(axisX, angleX, Space.World);

        Vector3 axisY = Vector3.Cross(transform.up, target.up).normalized;
        float angleY = -Mathf.Acos(Vector3.Dot(transform.up, target.up)) * Mathf.Rad2Deg;
        target.Rotate(axisY, angleY, Space.World);
    }
}
