using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Networking;

using System.IO;

public class httprequest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //StartCoroutine(GetText());
    }

    public void Play()
    {
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {      
        Test myTest;
        UnityWebRequest getReq = UnityWebRequest.Get("http://localhost:8080/api/Question/");
        yield return getReq.SendWebRequest();

         if (getReq.result != UnityWebRequest.Result.Success) {
            Debug.Log(getReq.error);
        }
        else {
            // Show results as text
            Debug.Log(getReq.downloadHandler.text);
            
            // Or retrieve results as binary data
            byte[] results = getReq.downloadHandler.data;

            
        }



    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
