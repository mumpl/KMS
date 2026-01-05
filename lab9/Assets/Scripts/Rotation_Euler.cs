using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Euler : MonoBehaviour
{
    public float speedX = 90f;
    public float speedZ = 60f;

    private float angleX;
    public float angleZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angleX += speedX * Time.deltaTime;
        angleZ += speedZ * Time.deltaTime;

        transform.eulerAngles = new Vector3 (angleX, 0f, angleZ);
    }   //вращение объекта
}
