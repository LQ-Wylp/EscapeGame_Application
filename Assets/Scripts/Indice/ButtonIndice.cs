using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonIndice : MonoBehaviour
{
    private EcranIndice _EcranIndice;

    private void Start() 
    {
        _EcranIndice = FindObjectOfType<EcranIndice>();
    }

    public void PressButton(int Number)
    {
        _EcranIndice.ChangeNumber(Number);
    }
}
