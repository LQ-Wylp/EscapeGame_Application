using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EcranCode : MonoBehaviour
{
    public List<Code> _GoodCode;
    public float _NumberOne;
    public float _NumberTwo;
    public float _NumberThree;
    public float _NumberFour;
    public int Index = 0;
    public Text _TextCode;

    public UnityEvent _BadCode;
    public void Init()
    {
        gameObject.SetActive(true);

        _NumberOne = 0;
        _NumberTwo = 0;
        _NumberThree = 0;
        _NumberFour = 0;

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
        if(Index == 2)
        {
            _NumberThree = Number;
        }
        if(Index == 3)
        {
            _NumberFour = Number;
        }

        Index++;
        if(Index >= 4)
        {
            Index = 0;
        }

        RefreshEcran();
    }

    public void RefreshEcran()
    {
        _TextCode.text = "" + _NumberOne + _NumberTwo + _NumberThree + _NumberFour;
    }

    public void CheckCode()
    {
        float CodeEntrer = _NumberOne * 1000 + _NumberTwo * 100 + _NumberThree * 10 + _NumberFour;

        bool Penality = true;

        for(int i = 0 ; i < _GoodCode.Count ; i++)
        {
            if(CodeEntrer == _GoodCode[i]._Code)
            {
                Penality = false;
                if(_GoodCode[i]._Activated == false)
                {
                    _GoodCode[i]._SuccesCode.Invoke();
                    _GoodCode[i]._Activated = true;
                }

            }
        }

        if(Penality)
        {
            _BadCode.Invoke();

        }

    }
}
