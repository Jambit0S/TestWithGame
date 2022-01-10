using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChieldMoving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            this.GetComponentInChildren<Transform>().localPosition=new Vector3(0,0,0);//Двигаем компоненты внутри обьекта
            //данный скрипт необходимо закинуть в ребенка обьекта, унутри которого мы будем двигаться

        }
    }
}
