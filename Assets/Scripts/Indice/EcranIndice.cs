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
    public float _NumberThree;
    public int Index = 0;
    public Text _TextCode;

    public UnityEvent _BadCode;
    public void Init()
    {
        gameObject.SetActive(true);

        _NumberOne = 0;
        _NumberTwo = 0;
        _NumberThree = 0;

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
        Index++;

        if(Index >= 3)
        {
            Index = 0;
        }

        RefreshEcran();
    }

    public void RefreshEcran()
    {
        _TextCode.text = "" + _NumberOne + _NumberTwo + _NumberThree;
    }

    public void CheckCode()
    {
        float CodeEntrer = _NumberOne * 100 + _NumberTwo * 10 + _NumberThree * 1;

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
