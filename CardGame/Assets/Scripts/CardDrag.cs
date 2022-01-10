using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDrag : MonoBehaviour
{
    float x;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        x= -1;
        y= -1;
        Debug.Log("x pos = "+x);
        Debug.Log("y pos = "+y);
        Debug.Log(Time.time);
        Transform a= this.GetComponent<Transform>();
        Debug.Log(a.position);
        Debug.Log(a.localPosition);

    }

    void OnMouseDrag()
    {
        if(x==-1 && y==-1)
        {
            float x = Input.mousePosition.x;
            float y = Input.mousePosition.y;
        }
       // rend.material.color-=Color.white*Time.deltaTime;
        float newX = Input.mousePosition.x;
        float newY = Input.mousePosition.y;
        //Debug.Log("x pos = "+newX);
        //Debug.Log("y pos = "+newY);
        this.GetComponent<Transform>().position=new Vector3(newX,newY,0);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            Transform a= this.GetComponent<Transform>();
            a.position= new Vector3(1093,197,0);
        }
        
    }
}
