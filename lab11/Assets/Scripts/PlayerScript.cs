using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * horizontal + transform.forward * vertical;
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

        float mouseX = Input.GetAxis("Mouse X");

        transform.Rotate(0, mouseX * rotateSpeed * Time.deltaTime, 0);
    }
}
