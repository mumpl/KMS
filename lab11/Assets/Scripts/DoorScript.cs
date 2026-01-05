using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Light point;
    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "player") point.enabled = true;
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.name == "player") point.enabled = false;
    }
    
}
