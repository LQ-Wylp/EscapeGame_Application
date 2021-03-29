using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

public class PorteDuTemple : MonoBehaviour
{
    public List<DisqueAmovible> _ListDisqueAmovible;
   // public UnityEvent _EventEnd;

    public GameObject AnimTemple;

    public void ChecekIfIsGood() 
    {
        bool EndEnigme = true;
        for(int i = 0 ; i < _ListDisqueAmovible.Count ; i++)
        {
            if(_ListDisqueAmovible[i]._Succes == false)
            {
                EndEnigme = false;
            }
        }

        if(EndEnigme)
        {
            AnimTemple.SetActive(true);
          //  _EventEnd.Invoke();
            for(int i = 0 ; i < _ListDisqueAmovible.Count ; i++)
            {
                _ListDisqueAmovible[i].enabled = false;
            }
        }
    }
}
