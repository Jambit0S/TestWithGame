using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCord;
    void OnMouseDown()
    {
        mZCord=Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Debug.Log(Camera.main.WorldToScreenPoint(gameObject.transform.position));
        Debug.Log(Camera.main.ScreenToWorldPoint(gameObject.transform.position));
        mOffset=gameObject.transform.position - GetMouseWorldPos();
    }
    Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z=mZCord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos()+mOffset;
    }
}
