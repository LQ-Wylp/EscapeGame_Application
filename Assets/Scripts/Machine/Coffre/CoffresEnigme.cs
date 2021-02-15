using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CoffresEnigme : MonoBehaviour
{
    public List<Sprite> _AllSymbole;
    public List<Image> _ImageSymbole;
    public List<int> _CodeRentrer; // Index = Index ImageSymbole
    public List<int> _BonCode;
    
    public UnityEvent EventEnd;

    public float _WaitingEnd;

    private void Start() 
    {
        RefreshVisuel();
    }

    public void CheckIfGoodCode()
    {
        bool IsGood = true;
        for(int i = 0 ; i < _CodeRentrer.Count ; i++)
        {
            if(_CodeRentrer[i] != _BonCode[i])
            {
                IsGood = false;
            }
        }

        if(IsGood)
        {
            EndEgnime();
        }
        
    }

    public void EndEgnime()
    {
        StartCoroutine(C_EndEgnime());
    }

    private IEnumerator C_EndEgnime()
    {
        yield return new WaitForSeconds(_WaitingEnd);

        EventEnd.Invoke();

    }

    public void IncreaseCode(int NumeroCode)
    {
        int Index = NumeroCode - 1;

        if(_CodeRentrer[Index] >= _AllSymbole.Count)
        {
            _CodeRentrer[Index] = 1;
        }
        else
        {
            _CodeRentrer[Index] += 1;
        }
        
        // Fonction Pour changer le symbole
        RefreshVisuel();

        CheckIfGoodCode();
    }

    public void DecreaseCode(int NumeroCode)
    {
        int Index = NumeroCode - 1;

        if(_CodeRentrer[Index] <= 1)
        {
            _CodeRentrer[Index] = _AllSymbole.Count;
        }

        else
        {
            _CodeRentrer[Index] -= 1;
        }
        
        // Fonction Pour changer le symbole
        RefreshVisuel();

        CheckIfGoodCode();
    }

    public void RefreshVisuel()
    {
        for(int i = 0; i < _ImageSymbole.Count; i++)
        {
            _ImageSymbole[i].sprite = _AllSymbole[_CodeRentrer[i] - 1];
        }
    }
}