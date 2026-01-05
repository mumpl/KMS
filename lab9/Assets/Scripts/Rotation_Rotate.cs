using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Rotate : MonoBehaviour
{
    public float angularSpeed = 90f;  //градусов в сек
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, angularSpeed * Time.deltaTime, 0f, Space.Self);
    }                                                    
}
