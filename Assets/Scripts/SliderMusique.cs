using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMusique : MonoBehaviour
{
    Slider _Slider;
    AudioManager _AudioManager;
    private void Start() 
    {
        _Slider = GetComponent<Slider>();
        _AudioManager = AudioManager.Instance();
    }

    private void Update() 
    {
        _AudioManager._VolumeGeneral = _Slider.value;
    }
}
