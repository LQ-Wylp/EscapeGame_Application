using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonStartPause : MonoBehaviour
{
    public UnityEvent _EventActive;
    public UnityEvent _EventDesactive;

    public void OnClick()
    {
        TimerManager _TimerManager = TimerManager.Instance();
        _TimerManager.SwitchModePause();

        if(TimerManager.Instance()._IsPaused)
        {
            _EventDesactive.Invoke();
        }
        else
        {
            _EventActive.Invoke();
        }

    }

    private void Start() 
    {
        if(TimerManager.Instance()._IsPaused)
        {
            _EventDesactive.Invoke();
        }
        else
        {
            _EventActive.Invoke();
        }
    }
}
