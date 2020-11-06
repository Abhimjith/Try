using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyTest : MonoBehaviour
{
    private GMScript gm;
    private MyGameStates SOG;
    void Start()
    {
        gm = FindObjectOfType<GMScript>();
        SOG = FindObjectOfType<MyGameStates>();
    }
    IEnumerator ThrowCard()
    {
        yield return new WaitForSeconds(1f);
        System.Random random = new System.Random();
        int index = random.Next(gm.EnemyCards.Count);
        GameObject kk = gm.EnemyArea.transform.Find(gm.EnemyCards[index]).gameObject;
        kk.GetComponent<UpdateCardInfo>().EnemyDraw();
        yield return new WaitForSeconds(0.5f);
        kk.gameObject.GetComponent<selectable>().IsFaceOn = true;
        
        yield return new WaitForSeconds(0.5f);
        SOG.State = MyGameStatesX.FREETODRAW;
        
    }

    public void TakeCard()
    {
        if(SOG.State==MyGameStatesX.ENEMYTURN)
        {
            if(gm.EnemyCards.Count <11)
            {
                gm.DrawNextECard(gm.EnemyCards,gm.EnemyArea);
                StartCoroutine(ThrowCard());
            }
        }
    }
    
    
}
