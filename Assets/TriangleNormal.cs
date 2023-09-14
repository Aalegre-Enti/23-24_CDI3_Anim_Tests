using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TriangleNormal : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public Transform C;
    public Vector3 cross;
    void Update()
    {
        Vector3 AB = B.position - A.position;
        Vector3 AC = C.position - A.position;
        cross = Vector3.Cross(AB, AC);
    }

    private void OnDrawGizmos()
    {
        Debug.DrawLine(A.position, B.position);
        Debug.DrawLine(B.position, C.position);
        Debug.DrawLine(A.position, C.position);
        Debug.DrawRay(A.position, cross, Color.yellow);
    }
}
