using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementOfThe : MonoBehaviour
{
    private TheManager _manager;
    public int _Index;

    public Sprite _ImageToShow;
    public Image _ShowWhere;

    private void Start()
    {
        _manager = FindObjectOfType<TheManager>();
    }

    public void PressButton(int Number)
    {

        _manager.Index = _Index;
    

        _manager.ChangeNumber(Number);

        _ShowWhere.sprite = _ImageToShow;
    }
}
