using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnCreateCard : MonoBehaviour
{
    public GameObject FolderPicters;
    
    // Start is called before the first frame update
    void Start()
    {
        Image myImage = this.GetComponentInChildren<Image>();

        SpriteRenderer[] img2 = FolderPicters.GetComponentsInChildren<SpriteRenderer>();
        Debug.Log("img count = "+img2.Length);

        int count = img2.Length;

        int pick=  Random.Range(1,count+1);
        //Debug.Log("img picked num = "+pick);

        this.GetComponentInChildren<Image>().sprite = img2[pick-1].sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
