using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ray : MonoBehaviour //, IPointerClickHandler
{
    public int force = 1000;
    public GameObject prefub2;
    // Start is called before the first frame update
    /*
    public void OnPointerClick(PointerEventData eventData)
    {
        
        Vector3 target = eventData.pointerPressRaycast.worldPosition;
        Vector3 collid = Camera.main.transform.position;
        Vector3 distance = target - collid;
        Vector3 direction = distance.normalized * force;

        gameObject.GetComponent<Rigidbody>().AddForceAtPosition(collid, target);
    }*/
    void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == this.gameObject)
        {
            Vector3 target = hit.point;
            Vector3 collid = Camera.main.transform.position;
            Vector3 distance = target - collid;
            Vector3 direction = distance.normalized * force;

            GetComponent<Rigidbody>().AddForceAtPosition(direction, target);
        }
    }
}
