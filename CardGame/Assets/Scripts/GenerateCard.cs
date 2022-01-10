using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime;

public class GenerateCard : MonoBehaviour
{
    public GameObject cardPrefub;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ButtonScriptStart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnActionButton()
    {
        Debug.Log("u Press the button");   
        SpawnCard();
        //StartTheGame();
    }
    private void SpawnCard()
    {
        GameObject a = Instantiate(cardPrefub) as GameObject;
        a.transform.parent = canvas.transform;
        a.GetComponent<Transform>().localPosition= new Vector3(100,200,0);     
        Card myCard = new Card();
        myCard.point = 12;
        myCard.microTheme="kke";
        a.GetComponent<CardDisplay>().card= myCard;
        
    }
    private void StartTheGame()
    {
        Debug.Log("Game is started");   
        GameObject a = Instantiate(cardPrefub) as GameObject;
        a.GetComponent<Transform>().position= new Vector3(0,0,0);
        Transform childTransform = transform.Find("Canvas");
        Debug.Log(childTransform.position);
        Debug.Log(childTransform.localPosition);
        GameObject b = Instantiate(cardPrefub) as GameObject;
        b.GetComponent<Transform>().position= new Vector3(500,500,0);
        GameObject c = Instantiate(cardPrefub) as GameObject;
        c.GetComponent<Transform>().position= new Vector3(750,500,0);
    }
}
