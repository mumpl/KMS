using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quanterion_new : MonoBehaviour
{
    private Quaternion startPosition;

    public float axisX = 1f;  
    public float axisY = 1f;   
    public float axisZ = 1f; 

    public float rotationSpeed = 90f;

    private float currentAngle;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        currentAngle += rotationSpeed * Time.deltaTime;

               //произв ось
        Vector3 arbitraryAxis = new Vector3 (axisX, axisY, axisZ).normalized; 
        Quaternion rotation = Quaternion.AngleAxis(currentAngle, arbitraryAxis);
        transform.rotation = startPosition * rotation;
    }
}
