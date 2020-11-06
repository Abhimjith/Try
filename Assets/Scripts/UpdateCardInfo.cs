using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpdateCardInfo : MonoBehaviour
{
    private GMScript gm;
    public Sprite Cardfaces;
    public Sprite CardBack;
    private selectable selectable;
    private SpriteRenderer Sprender;
    private SortingAndSetCreating SSC;
    private MyGameStates SOG;
    private EnemyTest ET;
    
    // Start is called before the first frame update
    void Start()
    {
        List<string> deck =  GMScript.CreateDeck();
        gm = FindObjectOfType<GMScript>();
        SSC= FindObjectOfType<SortingAndSetCreating>();
        SOG = FindObjectOfType<MyGameStates>();
        ET = FindObjectOfType<EnemyTest>();
        int i=0;

        foreach (string card in deck)
        {
            if (this.name == card)
            {
                Cardfaces = gm.Cards[i];
                
                break;
            }
            i++;
        }
        Sprender = GetComponent<SpriteRenderer>();
        selectable = GetComponent<selectable>();
    }

    public void OnMouseDown()
    {
        if(SOG.State==MyGameStatesX.PLAYERTURN)
        {
            int kk;string jk;
            if(gm.PlayerCards.Contains(this.name))
            {
                StartCoroutine(Moveit(gm.DropArea.transform.position.x ,gm.DropArea.transform.position.y,gm.DropArea.transform.position.z+gm.z,this.gameObject,gm.DropArea));
                gm.z=gm.z-0.08f;
                
                kk=GetVal(this.name);
                if(kk>10){kk=10;}
                gm.PScore=gm.PScore-kk;

                gm.PlayerCards.Remove(this.name);
                if(SSC.SSet.Contains(this.name))
                {
                    SSC.SSet.Remove(this.name);
                    SSC.SSet.Sort();
                }
                else if(SSC.HSet.Contains(this.name))
                {
                    SSC.HSet.Remove(this.name);
                    SSC.HSet.Sort();
                }
                else if(SSC.DSet.Contains(this.name))
                {
                    SSC.DSet.Remove(this.name);
                    SSC.DSet.Sort();
                }
                else if(SSC.CSet.Contains(this.name))
                {
                    SSC.CSet.Remove(this.name);
                    SSC.CSet.Sort();
                }

                if(gm.SetArea.transform.Find(this.name))
                {
                    
                    jk = this.name.Substring(1);
                    if(GetCount(jk)<4)
                    {
                        foreach (var item in gm.SetList)
                        {   
                            if(item.Substring(1)==jk)
                            {
                                if(gm.SetArea.transform.Find(item))
                                {
                                    gm.SetArea.transform.Find(item).gameObject.SetActive(false);
                                    gm.CompletedSetList.Remove(item);
                                }
                            }
                        }
                    }
                    else
                    {
                        if(gm.SetArea.transform.Find(this.name))
                                {
                                    gm.SetArea.transform.Find(this.name).gameObject.SetActive(false);
                                    gm.CompletedSetList.Remove(this.name);
                                }
                    }
                    
                }
                
                gm.SetList.Remove(this.name);
                gm.DroppedCards.Add(this.name);

                SOG.State=MyGameStatesX.ENEMYTURN;
                StartCoroutine(Waitforasec());

            }
            
        } 
    }

    int GetCount(string t)
    { int c=0;string gg;
        if(gm.SetList.Contains(t))
        {
            foreach (var item in gm.SetList)
            {   gg=item.Substring(1);
                if(gg==t)
                {
                    c++;
                }
            }
        }
        return c;
    }
    int GetVal(string j)
    {
        j = j.Substring(1);
       return int.Parse(j);
    }
    IEnumerator Waitforasec()
    {
        yield return new WaitForSeconds(2f);
        ET.TakeCard();
    }

    IEnumerator Moveit(float x,float y ,float z,GameObject card,GameObject Area)
    {
        yield return new WaitForSeconds(1f);
        iTween.MoveTo(card, new Vector3(x, y, z), 0.2f);
        yield return new WaitForSeconds(0.3f);
        card.transform.SetParent(Area.transform, true);
    }

    public void EnemyDraw()
    {
        if(gm.EnemyCards.Contains(this.name))/////////-----------------------------------------------/////////////
        {
            
            StartCoroutine(Moveit(gm.DropArea.transform.position.x ,gm.DropArea.transform.position.y,gm.DropArea.transform.position.z+gm.z,this.gameObject,gm.DropArea));
            gm.z=gm.z-0.08f;
            //this.selectable.IsFaceOn = true;
            gm.DroppedCards.Add(this.name);
            
            gm.EnemyCards.Remove(this.name);
        }
    }
    



    // Update is called once per frame
    void Update()
    {
        if(selectable.IsFaceOn)
        {
            Sprender.sprite = Cardfaces;
        }
        else
        {
            Sprender.sprite = CardBack;
        }
    }
}
