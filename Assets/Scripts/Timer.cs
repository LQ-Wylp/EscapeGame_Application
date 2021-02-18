using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [Header("Setting Timer")]
    public float _StartTime;
    public static float _RemainingTime;
    public static bool _TimerSetup = false;
    private float _TimeInitial;
    public bool _IsPaused = true;
    private float _Minutes;
    private float _Seconds;

    [Header("Editeur Setting")]
    public Text _TimerText;

    [Header("Timer Croissant")]
    public UnityEvent _StartExtraTime;
    public static bool _EndTime = false;
    public static float _ExtraTime = 0;

    [Header("Penality")]
    public float _PenalityTime;

    private void Awake() 
    {
        if(_TimerSetup == false)
        {
            _RemainingTime = _StartTime;
            _TimerSetup = true;
        }
    }

    private void Start()
    {
        _TimeInitial = _RemainingTime;
        Init();
    }

    public void SwitchModePause()
    {
        _IsPaused = !_IsPaused;
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

            if(_EndTime == false)
            {
                _RemainingTime -= Time.deltaTime;
            }


            if(_RemainingTime <= 0 && _EndTime == false)
            {
                _EndTime = true;
                _ExtraTime = _RemainingTime * -1;
                _StartExtraTime.Invoke();
            }

            if(_EndTime == true)
            {
                _ExtraTime += Time.deltaTime;
            }

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

        float RemainingTimeCopie = 0;
        if(_EndTime)
        {
            RemainingTimeCopie = _ExtraTime;
        }
        else
        {
            RemainingTimeCopie = _RemainingTime;
        }

        for(int i = 0 ; RemainingTimeCopie >= 60 ; i++)
        {   
            RemainingTimeCopie -= 60;
            _Minutes++;
        }

        if(_EndTime)
        {
            _Seconds = _ExtraTime - (60 * _Minutes);
        }
        else
        {
            _Seconds = _RemainingTime - (60 * _Minutes);
        } 
    }

    public void Penality()
    {
        if(_EndTime)
        {
            _ExtraTime += _PenalityTime;
        }

        else
        {
            _RemainingTime -= _PenalityTime;
        }
    }
}
