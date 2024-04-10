using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Transform_Rotate : MonoBehaviour
{
    public Transform ObjectToRotate;
    float rotationSpeed = 7f;

    void Update()
    {
        Translate();
    }

    void Translate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ObjectToRotate.Rotate(Vector3.up, -rotationSpeed * 10 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            ObjectToRotate.Rotate(Vector3.up, rotationSpeed * 10 * Time.deltaTime);
        }
    }
}
