using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawnPlacer : MonoBehaviour
{ 
    public GameObject card;
    public GameObject spawnPlace;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject card = this.gameObject;       
        Debug.Log("CardCords: "+ card.GetComponent<Transform>().localPosition);
        Debug.Log("SPCords: "+ spawnPlace.GetComponent<Transform>().position);
        card.GetComponent<Transform>().position=spawnPlace.GetComponent<Transform>().position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
