using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _AudioManager = null;
    public float _VolumeGeneral;

    public static AudioManager Instance()
    {
        return _AudioManager;
    }

    private void Awake() 
    {
        if(_AudioManager == null)
        {
            _AudioManager = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    


}
