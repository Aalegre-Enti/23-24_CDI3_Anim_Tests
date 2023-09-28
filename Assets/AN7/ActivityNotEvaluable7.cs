using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityNotEvaluable7 : MonoBehaviour
{
    public Transform target;
    public float animationTime;

    public enum ROTATION { INSTANT, ANIMATION}
    public ROTATION rotation;
    public enum MODE { ANGLE_AXIS, ROTATE}
    public MODE mode;

    Quaternion offset;
    float angle;
    Vector3 axis;
    float angleTEMP;

    private void Start()
    {
        offset = transform.rotation;
        offset.ToAngleAxis(out angle, out axis);
        angleTEMP = 0.0f;
    }

    private void Update()
    {
        if (angleTEMP < angle)
            angleTEMP += Time.deltaTime / animationTime;
        switch (mode)
        {
            case MODE.ANGLE_AXIS:
                target.rotation = Quaternion.AngleAxis(angleTEMP, axis);
                break;
            case MODE.ROTATE:
                break;
        }
    }
}
