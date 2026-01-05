using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        float red = Random.Range(.0f, 1.0f);
        float green = Random.Range(.0f, 1.0f);
        float blue = Random.Range(.0f, 1.0f);

        Color col1 = new Color(red, green, blue);

        GetComponent<Renderer>().material.color = col1;
    }
}
