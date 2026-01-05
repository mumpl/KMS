using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPosition : MonoBehaviour  //базовый класс, жц GameObject, от него наследуются все скрипты относящиеся к объектам
{
    public float speedX = 5f;
    public float speedY = 0.5f;
    public float speedZ = -1f;
    // Start is called before the first frame update
    void Start()  //иниц-я, вызывается автоматически один раз перед первым кадром
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(
            speedX * Time.deltaTime,   //время, прошедшее с момента завершения предыдущего кадра
            speedY * Time.deltaTime,
            speedZ * Time.deltaTime
            );
    }
}
