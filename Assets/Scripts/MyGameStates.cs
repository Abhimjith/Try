using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MyGameStatesX {START,FREETODRAW,PLAYERTURN,ENEMYTURN}
public class MyGameStates : MonoBehaviour
{
    public MyGameStatesX State;
    // Start is called before the first frame update
    void Start()
    {
        State = MyGameStatesX.START;
        StartCoroutine(GameStart());
    }
    IEnumerator GameStart()
    {
        yield return new WaitForSeconds(2f);
        State = MyGameStatesX.FREETODRAW;
        yield return new WaitForSeconds(1f);
    }

    
}
