using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float mouseSensetivity = 2f;

    public GameObject Cube1;
    public GameObject Cube2;

    public Texture texture1;
    public Texture texture2;

    public Texture keyboardTexture1;
    public Texture keyboardTexture2;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   //блок курсора мыши в центре экрана
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed *  Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensetivity; 
        transform.Rotate(0, mouseX, 0);

        if (Input.GetKey(KeyCode.Alpha1) && Cube1 != null)
        {
            Cube1.GetComponent<Renderer>().material.mainTexture = keyboardTexture1;
        }
        if (Input.GetKey(KeyCode.Alpha2) && Cube2 != null)
        {
            Cube2.GetComponent<Renderer>().material.mainTexture = keyboardTexture2;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        /*
        if (col.gameObject.name == "Cube1")
        {
            col.gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        }
        if (col.gameObject.name == "Cube2")
        {
            col.gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 1);
        }*/
        
        if (col.gameObject.name == "Cube1")
        {
            col.gameObject.GetComponent<Renderer>().material.mainTexture = texture1;
        }
        if (col.gameObject.name == "Cube2")
        {
            col.gameObject.GetComponent<Renderer>().material.mainTexture = texture2;
        }
    }
    void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
