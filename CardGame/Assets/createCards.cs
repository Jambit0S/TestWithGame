using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCards : MonoBehaviour
{
    public QuestionGroup pickedQuesiton;
    public GameObject cardPrefub;
   // public GameObject pickedCanvas;
    // Start is called before the first frame update
    void Start()
    {
        if(pickedQuesiton.id_groupQue.Count==0)
        {
            Debug.Log("Too fast BOUIII");
        }
        else
        {
            Debug.Log("picked count "+pickedQuesiton.id_groupQue.Count);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(pickedQuesiton.id_groupQue.Count!=0)
        {
            Debug.Log("okey"); 
            for(int i=0;i<pickedQuesiton.id_groupQue.Count;++i)
            {
                Instantiate(cardPrefub, new Vector3(100, 100, 0), Quaternion.identity);
                //cardPrefub.transform.parent=pickedCanvas.transform;
            }

            this.GetComponent<createCards>().enabled=false;
        }
        else
        {
            Debug.Log("count == 0 ");
        }
    }
}
