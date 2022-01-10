using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;




public class TestCreate : MonoBehaviour
{
    public GameObject myPrefub;
    public TestForCreate test;
    private int weightSum;
    public QuestionGroup queGroup;
    private static List<int> pickedQuestion =new List<int>();
    private static List<QuestionJson> pickedQuestionObj= new List<QuestionJson>();
    // Start is called before the first frame update
    void Start()
    {
        queGroup.id_groupQue.Clear();
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {      
        //UnityWebRequest getReq = UnityWebRequest.Get("http://localhost:8080/student/test/");
        UnityWebRequest getReq = UnityWebRequest.Get(test.testPickString);
        yield return getReq.SendWebRequest();

         if (getReq.result != UnityWebRequest.Result.Success) {
            Debug.Log(getReq.error);
        }
        else {
            // Show results as text
            Debug.Log(getReq.downloadHandler.text);
            
            TestJson MyTest = JsonUtility.FromJson<TestJson>(getReq.downloadHandler.text);
            Debug.Log("Был выбран тест под именем "+ MyTest.name);
            Debug.Log("Был выбран тест под id "+ MyTest.id);
            Debug.Log("Был выбран тест под criterion "+ MyTest.criterion);
            Debug.Log("Был выбран тест под quelist "+ MyTest.questionlist);
            
            weightSum=MyTest.weightsum;
            Debug.Log("Кол баллов за тест " + MyTest.weightsum);         
            
            //StartCoroutine(GetQuestionWeight(1));
            
            PickQuestionsByCritery(MyTest.questionlist);
        }
    }

    void PickQuestionsByCritery( int[] Questions )
    {
        List<int> unpickedQue= new List<int>();
        

        foreach (int num in Questions)
        {
            unpickedQue.Add(num);
        }

        foreach(var a in unpickedQue)
        {
            Debug.Log("unpick "+ a);
        }

        while(unpickedQue.Count>0)
        {
            int pickId = Random.Range(0,unpickedQue.Count-1);
            /*Debug.Log("Count = "+ unpickedQue.Count);
            Debug.Log("pickid "+ pickId);
            Debug.Log("unpick[pickid] "+ unpickedQue[pickId]);*/
            
            StartCoroutine(GetQuestionWeight(unpickedQue[pickId]));

            unpickedQue.RemoveAt(pickId);

        }
        Instantiate(myPrefub, new Vector3(0, 0, 0), Quaternion.identity);
        
        

    }
    IEnumerator GetQuestionWeight(int id_que)
    {
        
        UnityWebRequest getReq = UnityWebRequest.Get("http://localhost:8080/general/question/"+id_que);
         yield return getReq.SendWebRequest();

         if (getReq.result != UnityWebRequest.Result.Success) {
            Debug.Log(getReq.error);
        }
        else {
            // Show results as text
            QuestionJson myquestion = JsonUtility.FromJson<QuestionJson>(getReq.downloadHandler.text);
            Debug.Log("Picked question weight is "+myquestion.weight);
            if(weightSum>=myquestion.weight)
                {
                    weightSum-=myquestion.weight;
                    Debug.Log("Sum ="+weightSum);
                    pickedQuestion.Add(myquestion.id);
                    Debug.Log("Question count = "+pickedQuestion.Count);
                    queGroup.id_groupQue.Add(myquestion.id);
                }
        }

        
    }
    
    
}
