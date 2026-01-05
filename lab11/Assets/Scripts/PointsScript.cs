using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsScript : MonoBehaviour
{
    public Light point1;
    public Light point2;
    public Light point3;

    public float maxIntensity = 3f;
    public float changeSpeed = 1f;
    public float cylinderRotationSpeed = 20f;

    public Transform cylinder; 

    private float currentIntensity = 0f;

    void OnTriggerStay(Collider col)
    {
        if (col.name == "player")
        {
            currentIntensity = Mathf.PingPong(Time.time * changeSpeed, maxIntensity);

            point1.intensity = currentIntensity;
            point2.intensity = currentIntensity;
            point3.intensity = currentIntensity;

            cylinder.Rotate(0, cylinderRotationSpeed * Time.deltaTime, 0);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.name == "player")
        {
            if (point1 != null) point1.intensity = 0;
            if (point2 != null) point2.intensity = 0;
            if (point3 != null) point3.intensity = 0;
        }
    }
}