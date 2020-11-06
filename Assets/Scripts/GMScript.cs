using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;

public class GMScript : MonoBehaviour
{
    public Sprite[] Cards;
    public GameObject CardPrefabs;
    public Sprite[] Deadwood;
    public GameObject DeadwoodPrefabs;
    public GameObject CardContainer;
    public GameObject PlayerArea;
    public GameObject EnemyArea;
    public GameObject DropArea;
    public GameObject SetArea;
    
    private MyGameStates SOG;
    public static string[] TypeOfCard = new string[] {"S","C","D","H"};
    public static string[] ValueOfCard = new string[] {"01","02","03","04","05","06","07","08","09","10","11","12","13"};
    public List<string> Deck;
    public List<string> PlayerCards;
    public List<string> EnemyCards;
    public List<string> DroppedCards;
    public List<string> SetSpritesList;
    public List<string> SetList;
    public List<string> CompletedSetList;
    bool Children = false;
    public int PScore=0;
    public float z=0.03f;
    private SortingAndSetCreating SS;
  
    
    // Start is called before the first frame update
    
    void Start()
    {
        Deck = new List<string>();
        DroppedCards = new List<string>();
        
        GameStart();
        SS = FindObjectOfType<SortingAndSetCreating>();
        SOG = FindObjectOfType<MyGameStates>();
        
        
        
        
    }
    

    public void GameStart()
    {
            
            Deck = CreateDeck();
            shuffle(Deck);
            SetSpritesList = CreateDeck();
            CardSpawn();
            DealCards();
              
            
    }

    public static List<string> CreateDeck()
    {
        List<string> newdeck = new List<string>();
        foreach (string TOC in TypeOfCard)
        {
            foreach (string VOC in ValueOfCard)
            {
                newdeck.Add(TOC+VOC);   
            }
        }
        return newdeck;
    }

    public void shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while(n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
        
        
    }

    

    public void CardSpawn()
    {
        float xoffset = 0; 
        float zoffset = 0.03f; 
        foreach (string cardname in Deck)
        {
            GameObject cards = Instantiate(CardPrefabs, new Vector3(CardContainer.transform.position.x + xoffset,CardContainer.transform.position.y,CardContainer.transform.position.z + zoffset),Quaternion.identity,CardContainer.transform);
            cards.name = cardname;
            
            xoffset = xoffset + 0.02f;
            zoffset = zoffset + 0.03f;
            
        }
    }
    void setCardFace()
    {
        if(PlayerArea.GetComponent<PlayerOrEnemy>().IsPlayer)
        {
            for(int j=0;j<PlayerArea.transform.childCount;j++)
                {
                    PlayerArea.transform.GetChild(j).gameObject.GetComponent<selectable>().IsFaceOn = true; 
                }
        }
       
    }
        int GetVal(string j)
    {
        j = j.Substring(1);
       return int.Parse(j);
    }

    void DealCards()
    {
       int i=0;
       
       int kk;
       for(i=0;i<20;i=i+2)
       {
           PlayerCards.Add(CardContainer.transform.GetChild(i).gameObject.name);
           
           kk=GetVal(CardContainer.transform.GetChild(i).gameObject.name);
           if(kk>10){kk=10;}
           PScore=PScore+kk;
           
           
        //    StopCoroutine(Moveit(PlayerArea.transform.position.x + xoffset,PlayerArea.transform.position.y,PlayerArea.transform.position.z + zoffset,CardContainer.transform.GetChild(i).gameObject,PlayerArea));
           Deck.RemoveAt(0);
           EnemyCards.Add(CardContainer.transform.GetChild(i+1).gameObject.name);
           
        //    StopCoroutine(Moveit(EnemyArea.transform.position.x + xoffset,EnemyArea.transform.position.y,EnemyArea.transform.position.z + zoffset,CardContainer.transform.GetChild(i+1).gameObject,EnemyArea));
            Deck.RemoveAt(0);
           
           
           
       }
        
       LetsSort(PlayerCards,PlayerArea,CardContainer);
       LetsSort(EnemyCards,EnemyArea,CardContainer);
       K();
       AddToDeadwd();


    }
    void AddToDeadwd()
    {
        foreach (var sp in SetSpritesList)
       { 
           if(PlayerCards.Contains(sp))
           {
               if(!SetList.Contains(sp))
                {
                     SetList.Add(sp);
                }
           }
       }
       SetList.Sort();
    }
    public void Deadww(string k)
    {
        if(!CompletedSetList.Contains(k))
        {
            GameObject deadwod = Instantiate(DeadwoodPrefabs, new Vector3(-8,SetArea.transform.position.y,SetArea.transform.position.z),Quaternion.identity,SetArea.transform);
            deadwod.name = k;
            CompletedSetList.Add(k);
                    
                
            // MoveDeadwod(SetArea.transform.position.x + xoffset,SetArea.transform.position.y,SetArea.transform.position.z + zoffset,SetArea.transform.Find(k).gameObject);
            
        }
        
       
    }
    public void MoveDeadwod(float x,float y ,float z,GameObject card)
    {
        iTween.MoveTo(card, new Vector3(x, y, z), 0.1f);
    }

    public void LetsSort(List<string> Cardlist,GameObject Area,GameObject Container)
    {
        
        float xoffset = -6; 
        float zoffset = 2f;
        Cardlist.Sort();
       foreach(var cardname in Cardlist)
        {
            
               
            StartCoroutine(Moveit(Area.transform.position.x + xoffset,Area.transform.position.y,Area.transform.position.z + zoffset,Container.transform.Find(cardname).gameObject,Area));
            xoffset = xoffset + 1f;
            zoffset = zoffset - 0.03f;
            
        }

    }
    public void TestSort(List<string> Cardlist,GameObject Area,GameObject CardNName)
    {

        float xoffset = -6; 
        float zoffset = 2f;
        int kk;
        Cardlist.Sort();
        CardNName.transform.SetParent(Area.transform, true);
        
        // StartCoroutine(Moveit(Area.transform.position.x + xoffset,Area.transform.position.y,Area.transform.position.z + zoffset,CardNName,Area));
        foreach(var c in Cardlist)
        {
            
            StartCoroutine(Moveit(Area.transform.position.x + xoffset,Area.transform.position.y,Area.transform.position.z + zoffset,Area.transform.Find(c).gameObject,Area));
            xoffset = xoffset + 1f;
            zoffset = zoffset - 0.03f;
        }
        kk=GetVal(CardNName.name);
        if(kk>10){kk=10;}
        //PScore=PScore+kk;
        
        
        

    }
    
    

    IEnumerator Moveit(float x,float y ,float z,GameObject card,GameObject Area)
    {
        yield return new WaitForSeconds(1f);
        iTween.MoveTo(card, new Vector3(x, y, z), 1.5f);
        yield return new WaitForSeconds(0.3f);
        card.transform.SetParent(Area.transform, true);
        
    }

    IEnumerator Showit(GameObject card)
    {
        yield return new WaitForSeconds(2f);
        card.GetComponent<selectable>().IsFaceOn = true;
    }
   
    public void K()
    {
        if(!Children)
        {
            if(PlayerArea.transform.childCount == 10)
            {
                Children = true;
                setCardFace();
                
            }
        }
    }
    IEnumerator NewFromOld()
    {
        yield return new WaitForSeconds(4f);
            float xoffset = 0; 
            float zoffset = 0.03f;
            Deck.AddRange(DroppedCards);
            DroppedCards.Clear();
            shuffle(Deck);
            foreach (var item in Deck)
            {
                if(DropArea.transform.Find(item))
                {
                    DropArea.transform.Find(item).gameObject.GetComponent<selectable>().IsFaceOn = false;
                    StartCoroutine(Moveit(CardContainer.transform.position.x + xoffset,CardContainer.transform.position.y,CardContainer.transform.position.z + zoffset,DropArea.transform.Find(item).gameObject,CardContainer));
                    xoffset = xoffset + 0.02f;
                    zoffset = zoffset + 0.03f;
                    
                }
                
            }
             
              
            
    }
    void CheckDeck()
    {
        if(Deck.Count==0)
        {
            StartCoroutine(NewFromOld());
        }
    }

    public void  DrawNextPCard(List<string> Cardlist,GameObject Area)
    {
        if(CardContainer.transform.childCount != 0 && Deck.Count != 0)
        {

            
              Cardlist.Add(CardContainer.transform.Find(Deck[0]).gameObject.name);
              SS.UpdGroup(CardContainer.transform.Find(Deck[0]).gameObject.name);
              TestSort(Cardlist,Area,CardContainer.transform.Find(Deck[0]).gameObject);
              StartCoroutine(Showit(Area.transform.Find(Deck[0]).gameObject));
              SS.GetComponent<SortingAndSetCreating>().K = true;
              AddToDeadwd();
              Deck.RemoveAt(0);
              SOG.State=MyGameStatesX.PLAYERTURN;
              
            
              
        }
    }
    public void  DrawNextECard(List<string> Cardlist,GameObject Area)
    {
        if(CardContainer.transform.childCount != 0 && Deck.Count != 0)
        {

            
              Cardlist.Add(CardContainer.transform.Find(Deck[0]).gameObject.name);
              TestSort(Cardlist,Area,CardContainer.transform.Find(Deck[0]).gameObject);
              Deck.RemoveAt(0);
              
            
              
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        
        K();
        CheckDeck();
        
       
    }
}
