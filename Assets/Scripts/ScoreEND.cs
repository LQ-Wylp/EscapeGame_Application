using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEND : MonoBehaviour
{
    private Text _MyText;
    private float _Minutes;
    private float _Seconds;
    private TimerManager _TimerManager;
    
    void Start()
    {
        _TimerManager = TimerManager.Instance();
        _MyText = FindObjectOfType<Text>();

        CalculeMinute();
        RefreshVisuel();
    }

    public void CalculeMinute()
    {
        _Minutes = 0;

        float RemainingTimeCopie = 0;
        if(_TimerManager._EndTime)
        {
            RemainingTimeCopie = _TimerManager._ExtraTime;
        }
        else
        {
            RemainingTimeCopie = _TimerManager._RemainingTime;
        }

        for(int i = 0 ; RemainingTimeCopie >= 60 ; i++)
        {   
            RemainingTimeCopie -= 60;
            _Minutes++;
        }

        if(_TimerManager._EndTime)
        {
            _Seconds = _TimerManager._ExtraTime - (60 * _Minutes);
        }
        else
        {
            _Seconds = _TimerManager._RemainingTime - (60 * _Minutes);
        } 
    }

    public void RefreshVisuel()
    {
        string ShowThatSeconds = "" + Mathf.Floor(_Seconds);
        string ShowThatMinutes = "" + _Minutes;

        if(_MyText != null)
        {  
            if(_Minutes < 10)
            {
                ShowThatMinutes = "0" + _Minutes;
            }
            
            if(Mathf.Floor(_Seconds) < 10)
            {
                ShowThatSeconds = "0" + Mathf.Floor(_Seconds);
            }

            if(_TimerManager._EndTime)
            {
                _MyText.text = "-" + ShowThatMinutes + " : " + ShowThatSeconds;
            }
            else
            {
                _MyText.text = "+" + ShowThatMinutes + " : " + ShowThatSeconds;
            }

        }
    }
}
