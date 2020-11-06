using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usort : MonoBehaviour
{
   private GMScript gm;
   private MyGameStates SOG;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GMScript>(); 
        SOG = FindObjectOfType<MyGameStates>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if(SOG.State==MyGameStatesX.FREETODRAW)
        {
            if(gm.PlayerCards.Count <11)
            {
                gm.DrawNextPCard(gm.PlayerCards,gm.PlayerArea);
            }
        }
        
    }
}
