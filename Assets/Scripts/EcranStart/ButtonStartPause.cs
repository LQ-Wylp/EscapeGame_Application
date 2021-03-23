using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonStartPause : MonoBehaviour
{
    public static bool _FirstPress = true;
    public UnityEvent _EventFirstPress;

    public void OnClick()
    {
        TimerManager _TimerManager = TimerManager.Instance();
        _TimerManager.SwitchModePause();

        if(_FirstPress)
        {
            _EventFirstPress.Invoke();
            _FirstPress = false;
        }

    }

    private void Start() 
    {
        if(_FirstPress == false)
        {
            _EventFirstPress.Invoke();
        }
    }
}
