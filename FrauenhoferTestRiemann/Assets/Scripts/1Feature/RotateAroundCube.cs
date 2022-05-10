using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundCube : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject pivotObject;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotObject.transform.position, new Vector3(1, 1, 0), rotationSpeed * Time.deltaTime);
    }
}
