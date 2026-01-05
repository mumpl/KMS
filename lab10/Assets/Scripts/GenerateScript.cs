using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateScript : MonoBehaviour
{
    MeshRenderer rend;

    public GameObject prefab1;

    public float minX; public float maxX;
    public float minZ; public float maxZ;
    public float nX; public float nY; public float nZ;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();

        minX = rend.bounds.min.x; maxX = rend.bounds.max.x;
        minZ = rend.bounds.min.z; maxZ = rend.bounds.max.z;

        nY = gameObject.transform.position.y + 5;
    }

    // Update is called once per frame
    void Update()
    {
        nX = Random.Range(minX, maxX);
        nZ = Random.Range(minZ, maxZ);

        if(Input.GetKeyDown(KeyCode.Q))
        {
            GameObject cub = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cub.transform.position = new Vector3(nX, nY, nZ);
            cub.AddComponent<Rigidbody>();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Quaternion rotZ = Quaternion.AngleAxis(-1, new Vector3(0, 0, 1));
            gameObject.transform.rotation *= rotZ;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = new Vector3(nX, nY, nZ);
            Instantiate(prefab1, position, Quaternion.identity);    
        }
    }
}
