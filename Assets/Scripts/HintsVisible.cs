using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintsVisible : MonoBehaviour
{
    private MyGameStates SOG;
    public Text DrawCard;
    public Text ThrowCard;
    void Start()
    {
        SOG = FindObjectOfType<MyGameStates>();
        DrawCard.gameObject.SetActive(false);
        ThrowCard.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(SOG.State==MyGameStatesX.FREETODRAW)
        {
            DrawCard.gameObject.SetActive(true);
            ThrowCard.gameObject.SetActive(false);
        }
        else if(SOG.State==MyGameStatesX.PLAYERTURN)
        {
            DrawCard.gameObject.SetActive(false);
            ThrowCard.gameObject.SetActive(true);
        }
        else if(SOG.State==MyGameStatesX.ENEMYTURN)
        {
            DrawCard.gameObject.SetActive(false);
            ThrowCard.gameObject.SetActive(false);
        }
        
        
    }
}
