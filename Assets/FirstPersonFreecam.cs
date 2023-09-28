using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonFreecam : MonoBehaviour
{
    public float sensitivity_horizontal;
    public float sensitivity_vertical;

    public float movementSpeed;

    void Update()
    {
        #region ROTACIÓN

        float mouseX = Input.GetAxis("Mouse X") * sensitivity_horizontal;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity_vertical;

        transform.localEulerAngles += new Vector3(mouseY, mouseX, 0);

        #endregion

        #region ACELERACIÓN

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position += transform.forward * vertical * movementSpeed * Time.deltaTime;

        transform.position += transform.right * horizontal * movementSpeed * Time.deltaTime;

        transform.position += (transform.forward * vertical * movementSpeed * Time.deltaTime) + (transform.right * horizontal * movementSpeed * Time.deltaTime);

        #endregion
    }
}
