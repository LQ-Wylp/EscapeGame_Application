using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KitsuneEndManager : MonoBehaviour
{
    public List<CharactereKitsune> _ListCharactereKitsune;
    public UnityEvent _EndEvent;
    public UnityEvent _EchecEvent;
    public void CheckEnd()
    {
        bool succes = true;
        for(int i = 0 ; i < _ListCharactereKitsune.Count ; i++)
        {
            if(_ListCharactereKitsune[i]._Selected == false)
            {
                succes = false;
            }
        }

        if(succes)
        {
            EndEnigme();
        }
        else
        {
            _EchecEvent.Invoke();
        }
    }
    void EndEnigme()
    {
        _EndEvent.Invoke();
    }
}
