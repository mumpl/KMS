using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VorotaScript : MonoBehaviour
{
    public GameObject stavnleft;
    public GameObject stavnright;

    public GameObject flyingCube;
    public float rotationSpeed = 30f;
    public float flySpeed = 2f;

    void OnTriggerEnter(Collider col)
    {
        if(col.name == "player")
        {
            stavnleft.transform.position -= new Vector3(0, 0, 0.5f);
            stavnright.transform.position += new Vector3(0, 0, 0.5f);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if(col.name == "player")
        {
            stavnleft.transform.position += new Vector3(0, 0, 0.5f);
            stavnright.transform.position -= new Vector3(0, 0, 0.5f);
        }
    }
    void OnTriggerStay(Collider col)
    {
        if(col.name == "player")
        {
            flyingCube.transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
            flyingCube.transform.Translate(0, 0, flySpeed * Time.deltaTime);
        }
        if (col.name == "robot")
        {
            flyingCube.transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
            flyingCube.transform.Translate(0, 0, flySpeed * Time.deltaTime);
        }

    }
}
