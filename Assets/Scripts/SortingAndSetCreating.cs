using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class SortingAndSetCreating : MonoBehaviour
{
    private GMScript gm;
    public bool K=true;
    public int PlayerScore;

    int[] ChkVal = {01,02,03,04,05,06,07,08,09,10,10,10,10};
    public List<string> SSet;
    public List<string> CSet;
    public List<string> DSet;
    public List<string> HSet;
    float xoffset = -8;float zoffset= 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GMScript>();
        PlayerScore = gm.PScore;
        CGroup();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (K)
        {
            if(gm.PlayerCards.Count>0)
            {   int S1=0,S2=0,S3=0,S4=0,S5=0,S6=0,S7=0,S8=0,S9=0,S10=0,S11=0,S12=0,S13=0;
                string M1=null,M2=null,M3=null,M4=null,M5=null,M6=null,M7=null,M8=null,M9=null,M10=null,M11=null,M12=null,M13=null;
                
                foreach (var card in gm.PlayerCards)
                {   
                    
                    if(card.Contains("01"))
                    {   M1=M1+card+"+";
                        S1=S1+1;
                        if(S1>2 && S1<5)
                        {
                            if(S1==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[0]*S1;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[0];
                            }
                            //print("Set of Aces"+M1);
                            
                        } 
                    }
                    else if(card.Contains("02"))
                    {
                        M2=M2+card+"+";
                        S2=S2+1;
                        if(S2>2 && S2<5)
                        {
                            if(S2==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[1]*S2;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[1];
                            }
                            //print("Set of Two's"+M2);
                            
                        } 
                    }
                    else if(card.Contains("03"))
                    {M3=M3+card+"+";
                        S3=S3+1;
                        if(S3>2 && S3<5)
                        {
                            if(S3==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[2]*S3;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[2];
                            }
                            //print("Set of Threes"+M3);
                            
                        } 
                    }
                    else if(card.Contains("04"))
                    {M4=M4+card+"+";
                        S4=S4+1;
                        if(S4>2 && S4<5)
                        {
                            if(S4==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[3]*S4;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[3];
                            }
                            //print("Set of Fours"+M4);
                        } 
                    }
                    else if(card.Contains("05"))
                    {M5=M5+card+"+";
                        S5=S5+1;
                        if(S5>2 && S5<5)
                        {
                            if(S5==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[4]*S5;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[4];
                            }
                            //print("Set of Fives"+M5);
                           
                        } 
                    }
                    else if(card.Contains("06"))
                    {M6=M6+card+"+";
                        S6=S6+1;
                        if(S6>2 && S6<5)
                        {
                            if(S6==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[5]*S6;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[5];
                            }
                           // print("Set of Sixes"+M6);
                           
                        } 
                    }
                    else if(card.Contains("07"))
                    {M7=M7+card+"+";
                        S7=S7+1;
                        if(S7>2 && S7<5)
                        {
                            if(S7==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[6]*S7;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[6];
                            }
                           // print("Set of Sevens"+M7);
                           
                        } 
                    }
                    else if(card.Contains("08"))
                    {M8=M8+card+"+";
                        S8=S8+1;
                        if(S8>2 && S8<5)
                        {
                            if(S8==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[7]*S8;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[7];
                            }
                           // print("Set of Eights"+M8);
                           
                        } 
                    }
                    else if(card.Contains("09"))
                    {M9=M9+card+"+";
                        S9=S9+1;
                        if(S9>2 && S9<5)
                        {
                            if(S9==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[8]*S9;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[8];
                            }
                            //print("Set of Nines"+M9);
                           
                        } 
                    }
                    else if(card.Contains("10"))
                    {M10=M10+card+"+";
                        S10=S10+1;
                        if(S10>2 && S10<5)
                        {
                            if(S10==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[9]*S10;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[9];
                            }
                            //print("Set of Tens"+M10);
                           
                        } 
                    }
                    else if(card.Contains("11"))
                    {M11=M11+card+"+";
                        S11=S11+1;
                        if(S11>2 && S11<5)
                        {
                            if(S11==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[10]*S11;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[10];
                            }
                            //print("Set of Jacks"+M11);
                           
                        } 
                    }
                    else if(card.Contains("12"))
                    {M12=M12+card+"+";
                        S12=S12+1;
                        if(S12>2 && S12<5)
                        {
                            if(S12==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[11]*S12;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[11];
                            }
                            //print("Set of Queens"+M12);
                           
                        } 
                    }
                    else if(card.Contains("13"))
                    {M13=M13+card+"+";
                        S13=S13+1;
                        if(S13>2 && S13<5)
                        {
                            if(S13==3)
                            {
                                PlayerScore=PlayerScore-ChkVal[12]*S13;
                            }
                            else
                            {
                                 PlayerScore=PlayerScore-ChkVal[12];
                            }
                            //print("Set of Kings"+M13);
                           
                        } 
                    }

                    
                }
                K=false;
                PrintSet(S1,M1);
                PrintSet(S2,M2);
                PrintSet(S3,M3);
                PrintSet(S4,M4);
                PrintSet(S5,M5);
                PrintSet(S6,M6);
                PrintSet(S7,M7);
                PrintSet(S8,M8);
                PrintSet(S9,M9);
                PrintSet(S10,M10);
                PrintSet(S11,M11);
                PrintSet(S12,M12);
                PrintSet(S13,M13);
                ConsecSet(SSet);
                ConsecSet(HSet);
                ConsecSet(DSet);
                ConsecSet(CSet);

               
                
            }
            
                    
            
        }
        
    }
    void ConsecSet(List<string> NewSet)
    {
        if(NewSet.Count>0)
        {
            List<int> kkm = new List<int>();
            List<String> NNlist = new List<String>();
            foreach (var item in NewSet)
            {
                kkm.Add(GetVal(item));
                
            }
            
            NNlist=consecutiveRanges(kkm.ToArray());
            PrintConSets(NewSet,NNlist);
            
        }
        
    }
static List<String> consecutiveRanges(int[] a)
{
    int length = 1;
    List<String> list = new List<String>();
 
    // If the array is empty,
    // return the list
    if (a.Length == 0)
    {
        return list;
    }
 
    // Traverse the array from first position
    for(int i = 1; i <= a.Length; i++)
    {
 
        // Check the difference between the
        // current and the previous elements
        // If the difference doesn't equal to 1
        // just increment the length variable.
        if (i == a.Length || a[i] - a[i - 1] != 1)
        {
 
            // If the range contains
            // only one element.
            // add it into the list.
            if (length == 1) 
            {
                list.Add(
                    String.Join("", a[i - length]));
            }
            else
            {
 
                // Build the range between the first
                // element of the range and the
                // current previous element as the
                // last range.
                list.Add(a[i - length] + 
                "+" + a[i - 1]);
            }
 
            // After finding the first range
            // initialize the length by 1 to
            // build the next range.
            length = 1;
        }
        else
        {
            length++;
        }
    }
    return list;
}
void PrintConSets(List<string> NeSet,List<string> NewSetValues)
{
    if(NeSet.Count>0)
    {
        string[] temp;int i;
        //List<string> NewSet,
        foreach(var it in NewSetValues)
        {
            if(it.Contains("+"))
            {
                temp=it.Split(new string[] { "+" }, StringSplitOptions.None);
                i=int.Parse(temp[1])-int.Parse(temp[0]);
                print(it);print(i);
                if(i>=2)
                {  int j=0;
                    foreach (var item in NeSet)
                    {
                        if(item.Contains(temp[0]))
                        {
                            if(gm.SetList.Contains(item))
                            {
                                j=gm.SetList.IndexOf(item);
                                print(j);
                            }
                        }
                    }
                    for(int m=0;m<=i;m++)
                    {
                        DisDwd(j,NeSet);
                        j++;
                    }

                }
            }
        }
    }
}
void DisDwd(int i,List<string> Nt)
{
    foreach (var item in Nt)
    {
        if(!gm.CompletedSetList.Contains(item))
        {
            if(gm.SetList.Contains(item))
            {
                gm.Deadww(gm.SetList[i]);
            }
        }
    }
    foreach (var k in gm.CompletedSetList)
    {
        gm.MoveDeadwod(gm.SetArea.transform.position.x + xoffset,gm.SetArea.transform.position.y,gm.SetArea.transform.position.z + zoffset,gm.SetArea.transform.Find(k).gameObject);
        xoffset = xoffset + 1f;
        zoffset = zoffset - 0.03f;
    }
    xoffset = -8;
    zoffset = 0.03f;
}

    void PrintSet(int S,string M)
    {
        string[] NewM; 
        if(S>2 && S<5)
        {
            M=M.Remove(M.Length - 1, 1);
            NewM=M.Split(new string[] { "+" }, StringSplitOptions.None);
            if(S==3)
            {
                
                foreach (var item in NewM)
                {
                    if(!gm.CompletedSetList.Contains(item))
                    {
                        if(gm.SetList.Contains(item))
                        {
                            gm.Deadww(item);
                        }
                    }
                    
                }
                foreach (var k in gm.CompletedSetList)
                {
                    gm.MoveDeadwod(gm.SetArea.transform.position.x + xoffset,gm.SetArea.transform.position.y,gm.SetArea.transform.position.z + zoffset,gm.SetArea.transform.Find(k).gameObject);
                    xoffset = xoffset + 1f;
                    zoffset = zoffset - 0.03f;
                }
               
                
                print(M);
            }
            else
            {
                foreach (var item in NewM)
                {
                    if(!gm.CompletedSetList.Contains(item))
                    {
                        if(gm.SetList.Contains(NewM[3]))
                        {
                            gm.Deadww(NewM[3]);
                        }
                    }
                    foreach (var k in gm.CompletedSetList)
                    {
                        gm.MoveDeadwod(gm.SetArea.transform.position.x + xoffset,gm.SetArea.transform.position.y,gm.SetArea.transform.position.z + zoffset,gm.SetArea.transform.Find(k).gameObject);
                        xoffset = xoffset + 1f;
                        zoffset = zoffset - 0.03f;
                    }
                    
                }
                
                
                print(M);

            }
            xoffset = -8;
            zoffset = 0.03f;
            
        }
        // else
        // {   if(M != null)
        //     {print("S: "+S+" M: "+M);}
        // }
        
    }
    int GetVal(string j)
    {
        j = j.Substring(1);
       return int.Parse(j);
    }
    void CGroup()
    {
         if(gm.PlayerCards.Count>0)
        {
            int i=0;
            for(i=0;i<gm.PlayerCards.Count;i++)
            {
                if(gm.PlayerCards[i].Contains("S"))
                {   
                    SSet.Add(gm.PlayerCards[i]);    
                }
                else if(gm.PlayerCards[i].Contains("C"))
                {   
                    CSet.Add(gm.PlayerCards[i]);    
                }
                else if(gm.PlayerCards[i].Contains("D"))
                {   
                    DSet.Add(gm.PlayerCards[i]);    
                }
                else if(gm.PlayerCards[i].Contains("H"))
                {   
                    HSet.Add(gm.PlayerCards[i]);    
                }
                    
            }
        }
    }
    public void UpdGroup(string card)
    {
        string c=card.Substring(0, 1);
        
            if(c=="S")
            {
                if(!SSet.Contains(card))
                {
                    SSet.Add(card);SSet.Sort();
                }
            }
            else if(c=="H")
            {
                if(!HSet.Contains(card))
                {
                    HSet.Add(card);HSet.Sort();
                }
            }
            else if(c=="D")
            {
                if(!DSet.Contains(card))
                {
                    DSet.Add(card);DSet.Sort();
                }
            }
            else if(c=="C")
            {
                if(!CSet.Contains(card))
                {
                    CSet.Add(card);CSet.Sort();
                }
            }
            
    }

    void GetSets()
    {
       
       int i=0;

            if(SSet.Count>2)
            {
                
            }
            if(CSet.Count>2)
            {
                for(i=0;i<CSet.Count;i++)
                {
                    for(int j=i+1;j<CSet.Count-1;j++)
                    {
                        if(GetVal(CSet[j])-GetVal(CSet[i])==1 && GetVal(CSet[j+1])-GetVal(CSet[i])==2)
                        {
                            print(CSet[i]+" "+CSet[j]+" "+CSet[j+1]);
                        }
                    }
                    
                }
            }
            if(DSet.Count>2)
            {
                for(i=0;i<DSet.Count;i++)
                {
                    for(int j=i+1;j<DSet.Count-1;j++)
                    {
                        if(GetVal(DSet[j])-GetVal(DSet[i])==1 && GetVal(DSet[j+1])-GetVal(DSet[i])==2)
                        {
                            print(DSet[i]+" "+DSet[j]+" "+DSet[j+1]);
                        }
                    }
                    
                }
            }
            if(HSet.Count>2)
            {
                for(i=0;i<HSet.Count;i++)
                {
                    for(int j=i+1;j<HSet.Count-1;j++)
                    {
                        if(GetVal(HSet[j])-GetVal(HSet[i])==1 && GetVal(HSet[j+1])-GetVal(HSet[i])==2)
                        {
                            print(HSet[i]+" "+HSet[j]+" "+HSet[j+1]);
                        }
                    }
                    
                }
            }
        
            
        
    }

    public void OnClick()
    {
        
        Application.Quit();
        
        
    }
}
