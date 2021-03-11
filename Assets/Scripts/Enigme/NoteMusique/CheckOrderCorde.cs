using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckOrderCorde : MonoBehaviour
{
    public List<int> _OrdreCordeJouer;
    public List<int> _OrdreVersLeBas;
    public List<int> _OrdreVersLeHaut;

    public UnityEvent _SuccesVersLeBas;
    public UnityEvent _SuccesVersLeHaut;


    public void SurvoleCorde(int NbCorde) 
    {
        _OrdreCordeJouer.Add(NbCorde);
        _OrdreCordeJouer.RemoveAt(0);

        checkIfActionCorrecte();
    }

    public void checkIfActionCorrecte()
    {
        bool SuccesBas = true;
        bool SuccesHaut = true;

        for(int i = 0; i < _OrdreCordeJouer.Count; i++)
        {
            if(_OrdreCordeJouer[i] != _OrdreVersLeBas[i])
            {
                SuccesBas = false;
            }

            if(_OrdreCordeJouer[i] != _OrdreVersLeHaut[i])
            {
                SuccesHaut = false;
            }
        }

        if(SuccesBas)
        {
            _SuccesVersLeBas.Invoke();
        }

        if(SuccesHaut)
        {
            _SuccesVersLeHaut.Invoke();
        }
    }

    public void ResetList()
    {
        for(int i = 0; i < _OrdreCordeJouer.Count; i++)
        {
            _OrdreCordeJouer[i] = 9;
        }
    }
}
