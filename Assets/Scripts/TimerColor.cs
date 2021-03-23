using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerColor : MonoBehaviour
{
    private Text _Text;

    Color _InitialColor;
    public Color _ColorExtraTimeOne;
    public Color _ColorExtraTimeTwo;


    public bool _ExtraTime;

    float _PourcentageColor = 0;

    public bool _DirectionVersColorOne = false;
    public float _FrequenceAlternante;

    public float _DurationFeedbackPenality;
    void Start()
    {
        _ExtraTime = TimerManager.Instance()._EndTime;
        _Text = GetComponent<Text>();
        _InitialColor = _Text.color;
        TimerManager.Instance().CalculeMinute();
        TimerManager.Instance().RefreshVisuel();
    }

    
    public void RefreshForColorExtraTime()
    {
        _ExtraTime = true;
    }

    public void FeedBackPenality()
    {
        StartCoroutine(ColorRedForTime(_DurationFeedbackPenality));
    }

    public IEnumerator ColorRedForTime(float duration)
    {
        float elapsed = 0.0f;

        while (elapsed < duration)
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

            elapsed += Time.deltaTime;
            yield return null;
        }

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
        else
        {
            _Text.color = _InitialColor;
        }
    }
}
