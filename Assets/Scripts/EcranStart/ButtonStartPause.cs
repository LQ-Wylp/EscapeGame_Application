using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStartPause : MonoBehaviour
{
    public void OnClick()
    {
        TimerManager _TimerManager = TimerManager.Instance();
        _TimerManager.SwitchModePause();
    }
}
