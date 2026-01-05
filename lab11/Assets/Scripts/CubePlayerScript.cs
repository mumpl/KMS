using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.T))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
}
