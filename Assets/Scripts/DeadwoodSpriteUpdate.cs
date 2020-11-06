using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadwoodSpriteUpdate : MonoBehaviour
{
    private GMScript gm;
    public Sprite Cardfaces;
    private SpriteRenderer Sprender;
    // Start is called before the first frame update
    void Start()
    {
        List<string> deck =  GMScript.CreateDeck();
        gm = FindObjectOfType<GMScript>(); 
        int i;

        foreach (string card in deck)
        {
            if (this.name == card)
            {
                i = deck.IndexOf(card);
                
                Cardfaces = gm.Deadwood[i];
                
                break;
            }
            
        }
        Sprender = GetComponent<SpriteRenderer>();
        Sprender.sprite = Cardfaces;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
