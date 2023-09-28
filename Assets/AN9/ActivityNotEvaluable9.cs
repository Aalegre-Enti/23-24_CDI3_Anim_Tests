using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityNotEvaluable9 : MonoBehaviour
{
    public Transform target1;
    public Transform target2;


    Quaternion offset, offset2;
    Quaternion conjugate(Quaternion q1)
    {
        Quaternion q2;
        q2.x = -q1.x;
        q2.y = -q1.y;
        q2.z = -q1.z;
        q2.w = q1.w;

        return q2;



    }

    private void Start()
    {

        offset = target1.rotation * conjugate(transform.rotation);
        offset2 = conjugate(offset);
    }
    private void Update()
    {
        target1.rotation = offset * transform.rotation;
        target2.rotation = offset2 * target1.rotation;
    }
}
