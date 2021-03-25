using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorTheText : MonoBehaviour
{
    public List<Text> _Text;
    public int _Index;

    public Color _ColorSelected;
    private Color _InitialColor;

    void Start()
    {
        _InitialColor = _Text[0].color;
        ActualiseVisuel();
    }

    void ActualiseVisuel()
    {
        for(int i = 0; i < _Text.Count; i++)
        {
            if(i == _Index)
            {
                _Text[i].color = _ColorSelected;
            }
            else
            {
                _Text[i].color = _InitialColor;
            }
        }
    }

    public void ButtonPressed(int NbButton)
    {
        _Index = NbButton;
        ActualiseVisuel();
    }
}
