using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TheManager : MonoBehaviour
{
    public List<int> bonneCombi;

    public UnityEvent endEvent;
    public UnityEvent ErrorEvent;
    public UnityEvent goodEvent;
    public Text textRecette;

    public float NumberOne;
    public float NumberTwo;
    public float NumberThree;
    public int Index = 0;
    int recipe = 1;


    void Start()
    {
        NumberOne = 0;
        NumberTwo = 0;
        NumberThree = 0;

        Index = 0;
    }

    public void ChangeNumber(int Number)
    {
        if (Index == 0)
        {
            NumberOne = Number;
        }
        if (Index == 1)
        {
            NumberTwo = Number;
        }
        if (Index == 2)
        {
            NumberThree = Number;
        }

        Index++;
        
    }

    public void CheckCombi()
    {
        float CodeEntrer = NumberOne * 1000 + NumberTwo * 100 + NumberThree;

        if (bonneCombi[0] == CodeEntrer)
        {
            if (recipe == 3)
            {
                endEvent.Invoke();
            }
            else
            {
                if(recipe == 1)
                {
                    textRecette.text = "Une grue endormi attend la fin du brouillard l'aube apaisante";
                }
                if(recipe == 2)
                {
                    textRecette.text = "L'orage fait rage le lapin va se terrer minuit retentit";
                }

                recipe++;

                goodEvent.Invoke();

                bonneCombi.RemoveAt(0);
            }  

        }
        else
        {
            ErrorEvent.Invoke();
        }
    }
}
