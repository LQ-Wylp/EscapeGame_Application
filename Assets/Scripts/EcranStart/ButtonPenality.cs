using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPenality : MonoBehaviour
{
    public void OnClick()
    {
        TimerManager _TimerManager = TimerManager.Instance();
        _TimerManager.Penality();
    }
}
