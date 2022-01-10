using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Networking;

public class getallTets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {      
        UnityWebRequest getReq = UnityWebRequest.Get("http://localhost:8080/student/test/");
        yield return getReq.SendWebRequest();

         if (getReq.result != UnityWebRequest.Result.Success) {
            Debug.Log(getReq.error);
        }
        else {
            // Show results as text
            Debug.Log(getReq.downloadHandler.text);
            
            // Or retrieve results as binary data
            byte[] results = getReq.downloadHandler.data;
            Test myTest=new Test();
            string json =JsonUtility.ToJson(myTest);  
            
            Debug.Log(json);
            
            

        }


        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

