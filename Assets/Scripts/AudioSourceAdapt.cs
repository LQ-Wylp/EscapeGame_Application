using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceAdapt : MonoBehaviour
{
    private AudioSource _AudioSource;
    private float _VolumeInitial;

    void Start()
    {
        _AudioSource = GetComponent<AudioSource>();
        _VolumeInitial = _AudioSource.volume;
        RefreshVolume();
    }

    public void RefreshVolume()
    {
        _AudioSource.volume = _VolumeInitial * AudioManager.Instance()._VolumeGeneral;
    }

    private void Update() 
    {
        RefreshVolume();
    }
}
