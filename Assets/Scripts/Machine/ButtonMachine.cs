using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMachine : MonoBehaviour
{
    private EcranMachine _EcranMachine;

    private void Start() 
    {
        _EcranMachine = FindObjectOfType<EcranMachine>();
    }

    public void PressButton(int Number)
    {
        _EcranMachine.ChangeNumber(Number);
    }
}
