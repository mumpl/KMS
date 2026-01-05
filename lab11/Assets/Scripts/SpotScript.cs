using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotScript : MonoBehaviour
{
    public Light spot;
    public float rotationSpeed = 50f;
    private void OnTriggerStay(Collider col)
    {
        if (col.name == "player")
            spot.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
