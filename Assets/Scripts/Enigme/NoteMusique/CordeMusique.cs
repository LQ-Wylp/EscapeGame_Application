using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CordeMusique : MonoBehaviour
{
    private bool _Pressed;
    public int _NumeroCorde;
    private NoteMusiqueManager _NoteMusiqueManager;

    private void Start() 
    {
        _NoteMusiqueManager = FindObjectOfType<NoteMusiqueManager>();
    }

    public void OnMouseDown() 
    {
        
        _NoteMusiqueManager.PressCorde(_NumeroCorde);
    }

}
