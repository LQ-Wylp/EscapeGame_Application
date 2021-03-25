using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetApplis : MonoBehaviour
{
    public void PressButton()
    {
        TimerManager.Instance().ResetGame();
    }
}
