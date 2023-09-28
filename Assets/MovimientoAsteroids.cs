using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAsteroids : MonoBehaviour
{
    public float rotationSpeed;
    public float accelerationSpeed;

    private void Update()
    {
        #region ROTACI�N
        float horizontal = Input.GetAxis("Horizontal");

        transform.localEulerAngles += new Vector3(0, 0, horizontal * Time.deltaTime * rotationSpeed);

        #endregion


        #region ACELERACI�N
        float vertical = Input.GetAxis("Vertical");

        float rad = transform.localEulerAngles.z * Mathf.Deg2Rad;

        Vector3 dir = new Vector3(-Mathf.Sin(rad), Mathf.Cos(rad));

        if (vertical > 0)
            transform.position += dir * vertical * accelerationSpeed * Time.deltaTime;

        #endregion
    }
}
