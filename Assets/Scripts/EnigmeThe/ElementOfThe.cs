using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementOfThe : MonoBehaviour
{
    private TheManager _manager;

    private void Start()
    {
        _manager = FindObjectOfType<TheManager>();
    }

    public void PressButton(int Number)
    {
        _manager.ChangeNumber(Number);
    }
}
