using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCode : MonoBehaviour
{
    private EcranCode _EcranCode;

    private void Start() 
    {
        _EcranCode = FindObjectOfType<EcranCode>();
    }

    public void PressButton(int Number)
    {
        _EcranCode.ChangeNumber(Number);
    }
}
