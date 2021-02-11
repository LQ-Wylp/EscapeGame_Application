using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TimerManager : MonoBehaviour
{
    private static TimerManager _TimerManager = null;

    public static TimerManager Instance()
    {
        return _TimerManager;
    }

    [Header("Setting Timer")]
    public float _StartTime;
    public float _RemainingTime;
    private bool _TimerSetup = false;
    private float _TimeInitial;
    public bool _IsPaused = true;
    private float _Minutes;
    private float _Seconds;

    [Header("Editeur Setting")]
    private Text _TimerText;

    [Header("Timer Croissant")]
    public UnityEvent _StartExtraTime;
    private bool _EndTime = false;
    public float _ExtraTime = 0;

    [Header("Penality")]
    public float _PenalityTime;



    private void Awake() 
    {
        if(_TimerManager == null)
        {
            _TimerManager = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        if(_TimerSetup == false)
        {
            _RemainingTime = _StartTime;
            _TimerSetup = true;
        }
        
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

        if(_TimerText == null)
        {
            if(GameObject.FindGameObjectWithTag("Text_Timer") != null)
            {         
                Text TextTimer = GameObject.FindGameObjectWithTag("Text_Timer").GetComponent<Text>();
                if(TextTimer != null)
                {   
                    _TimerText = TextTimer;
                }
            }
        }

        if(_TimerText != null)
        {  
            _TimerText.text = ShowThatMinutes + " : " + ShowThatSeconds;
        }
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
