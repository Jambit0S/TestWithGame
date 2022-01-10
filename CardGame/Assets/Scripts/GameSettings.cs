using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{

    
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        Transform canvas = this.GetComponent<Transform>();
        Camera.GetComponent<Transform>().position=canvas.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
