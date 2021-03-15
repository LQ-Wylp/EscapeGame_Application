using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerColor : MonoBehaviour
{
    private Text _Text;

    public Color _ColorExtraTimeOne;
    public Color _ColorExtraTimeTwo;

    public bool _ExtraTime;

    float _PourcentageColor = 0;

    public bool _DirectionVersColorOne = false;
    public float _FrequenceAlternante;
    
    void Start()
    {
        _Text = GetComponent<Text>();
    }

    
    public void RefreshForColorExtraTime()
    {
        _ExtraTime = true;
    }

    private void Update() 
    {


        if(_ExtraTime)
        {
            if(_DirectionVersColorOne)
            {
                _PourcentageColor -= Time.deltaTime * _FrequenceAlternante;
                if(_PourcentageColor <= 0)
                {
                    _DirectionVersColorOne = false;
                }
            }

            else
            {
                _PourcentageColor += Time.deltaTime * _FrequenceAlternante;
                if(_PourcentageColor >= 1)
                {
                    _DirectionVersColorOne = true;
                }
            }

            Color ColorApplique = Color.Lerp(_ColorExtraTimeOne, _ColorExtraTimeTwo, _PourcentageColor);
            _Text.color = ColorApplique;
        }
    }
}
