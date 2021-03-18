using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementOfThe : MonoBehaviour
{
    private TheManager _manager;
    public bool _First;

    private void Start()
    {
        _manager = FindObjectOfType<TheManager>();
    }

    public void PressButton(int Number)
    {
        if(_First)
        {
            _manager.Index = 0;
        }

        _manager.ChangeNumber(Number);
    }
}
