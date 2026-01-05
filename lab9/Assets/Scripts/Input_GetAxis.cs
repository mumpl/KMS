using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Input_GetAxis : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;

    private float verticalAngle = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                             //ввод с клавишь  A,D стрелки. возвращает от -1 до 1
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(x * moveSpeed * Time.deltaTime, 0, z * moveSpeed * Time.deltaTime);

        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        float horizontalRotation = mx * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, horizontalRotation, 0);

        verticalAngle -= my * rotationSpeed * Time.deltaTime;
        verticalAngle = Mathf.Clamp(verticalAngle, 0f, 90f);

        transform.rotation = Quaternion.Euler(verticalAngle, transform.eulerAngles.y + my * rotationSpeed * Time.deltaTime, 0f); 
    }
}
