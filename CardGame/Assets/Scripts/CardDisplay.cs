using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text microThemeText;
    public Text pointText;
    public Image artWorkImage;
    // Start is called before the first frame update
    void Start()
    {
        microThemeText.text=card.microTheme;
        pointText.text = card.point.ToString();
        artWorkImage.sprite = card.artWork;
    }

    
}
