using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PurificationTempleManager : MonoBehaviour
{
    public UnityEvent _EndEvent;
    public List<int> _CodeEntrer;
    public List<int> _CodeBon;

    public void PressAction(int NumeroCorde)
    {
        _CodeEntrer.Add(NumeroCorde);
        _CodeEntrer.RemoveAt(0);

        CheckCode();
    }

    void CheckCode()
    {
        bool succes = true;

        for(int i = 0; i < _CodeEntrer.Count; i++)
        {
            if(_CodeEntrer[i] != _CodeBon[i])
            {
                succes = false;
            }
        }

        if(succes)
        {
            EndEnigme();
        }
    }
    void EndEnigme()
    {
        _EndEvent.Invoke();
    }
}
