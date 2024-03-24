using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePropellerController : MonoBehaviour
{
    public float rotationSpeed;

    void LateUpdate()
    {
        transform.Rotate(Vector3.back * Time.deltaTime * rotationSpeed);
    }
}
