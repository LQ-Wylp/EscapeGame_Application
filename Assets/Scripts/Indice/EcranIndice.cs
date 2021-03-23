using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EcranIndice : MonoBehaviour
{
    public List<Indice> _GoodCode;
    public float _NumberOne;
    public float _NumberTwo;
    public int Index = 0;
    public Text _TextCode;

    public UnityEvent _BadCode;
    public void Init()
    {
        gameObject.SetActive(true);

        _NumberOne = 0;
        _NumberTwo = 0;

        RefreshEcran();

        Index = 0;
    }

    public void ChangeNumber(int Number)
    {
        if(Index == 0)
        {
            _NumberOne = Number;
        }
        if(Index == 1)
        {
            _NumberTwo = Number;
        }
        Index++;

        if(Index >= 2)
        {
            Index = 0;
        }

        RefreshEcran();
    }

    public void RefreshEcran()
    {
        _TextCode.text = "" + _NumberOne + _NumberTwo;
    }

    public void CheckCode()
    {
        float CodeEntrer = _NumberOne * 10 + _NumberTwo * 1;

        bool FalseCode = true;

        for(int i = 0 ; i < _GoodCode.Count ; i++)
        {
            if(CodeEntrer == _GoodCode[i]._Code)
            {
                FalseCode = false;
                _GoodCode[i]._SuccesCode.Invoke();
            }
        }

        if(FalseCode)
        {
            _BadCode.Invoke();
        }
    }
}
