using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAcceleration : MonoBehaviour
{
    Vector3 velocity;
    void FixedUpdate()
    {
        velocity += Physics.gravity * Time.fixedDeltaTime;
        transform.position += velocity * Time.fixedDeltaTime * Time.fixedDeltaTime;
    }
}
