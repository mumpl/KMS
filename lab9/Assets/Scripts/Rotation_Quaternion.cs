using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Quaternion : MonoBehaviour
{
    private Quaternion startPosition;

    public float speedX = 90f;
    public float speedZ = 60f;

    private float angleX;
    public float angleZ;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        angleX += speedX * Time.deltaTime;
        angleZ += speedZ * Time.deltaTime;
         
       //создает кватернион вращ-я вокруг оси     угол     ось    вектор 1 0 0        
        Quaternion rotX = Quaternion.AngleAxis(angleX, Vector3.right);
        Quaternion rotZ = Quaternion.AngleAxis(angleZ, Vector3.forward);

        transform.rotation = startPosition * rotX * rotZ;
    }
}
