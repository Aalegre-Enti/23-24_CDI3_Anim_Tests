using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityNotEvaluable8 : MonoBehaviour
{
    public Transform target;
    public Camera camera;
    public Transform head;

    Quaternion offset3, offsetHead, offsetCamera;

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

        //we remove the offset of the transform, and add the offset of target1.
        offset3 = target.rotation * conjugate(transform.rotation);
        Debug.Log("head.rotation: " + head.rotation);

        //we remove the offset of the transform and add the offset of the camera
        offsetCamera = camera.transform.rotation * conjugate(transform.rotation);

        //we add the offset of the head and remove the offset of the camera
        offsetHead = conjugate(camera.transform.rotation) * head.rotation;
    }

    private void Update()
    {

        target.rotation = offset3 * transform.rotation;
        //offset3 takes the current transform, removes the initial rotation of the transform, and adds the initial rotation of target1.
        //here we preserve the offset. When transform rotates on its the X axis, target1 rotates on its X axis.  

        camera.transform.rotation = offsetCamera * transform.rotation;
        //idem

        //offsetHead = conjugate(cameraInitial.rotation) * headInitial.rotation;
        head.rotation = camera.transform.rotation * offsetHead;//here we want head rotation to be aligned with camera, instead of each following its own axis.                                               
                                                     //this is different. Why?
                                                     //we do not want a rotation on the x axis of camera to correspond
                                                     //to a rotation on the x axis of the head.
                                                     //how it works: 
                                                     //removes the initial rotation of the camera so we are left with only the rotation added to with new camera rotation
                                                     //Then adds the offset from the mark of reference of the head, so that the final result is the offset rotation of the camera from the mark
                                                     //of reference + the rotation of the head
                                                     // When camera rotates on its X axis, head rotates on the X axis of camera (not of head)


        //notice: in the initial project the rotation of the camera was null. To test better this environment, try tilting down the camera a bit.
    }
}
