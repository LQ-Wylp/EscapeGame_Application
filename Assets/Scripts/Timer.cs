using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Setting Timer")]
    public float _RemainingTime;
    private float _TimeInitial;
    public bool _IsPaused = true;
    private float _Minutes;
    private float _Seconds;

    [Header("Editeur Setting")]
    public Text _TimerText;

    private void Start()
    {
        _TimeInitial = _RemainingTime;
        Init();
    }

    public void Init()
    {
        _IsPaused = true;
        _RemainingTime = _TimeInitial;

        CalculeMinute();
        RefreshVisuel();
    }

    private void Update()
    {
        if(_IsPaused == false)
        {
            _RemainingTime -= Time.deltaTime;
            CalculeMinute();
            RefreshVisuel();
        }
    }

    public void RefreshVisuel()
    {
        string ShowThatSeconds = "" + Mathf.Floor(_Seconds);
        string ShowThatMinutes = "" + _Minutes;

        _TimerText.text = ShowThatMinutes + " : " + ShowThatSeconds;
    }

    public void CalculeMinute()
    {
        _Minutes = 0;

        
        float RemainingTimeCopie = _RemainingTime;

        for(int i = 0 ; RemainingTimeCopie >= 60 ; i++)
        {   
            RemainingTimeCopie -= 60;
            _Minutes++;
        }

        _Seconds = _RemainingTime - (60 * _Minutes);
    }
}
