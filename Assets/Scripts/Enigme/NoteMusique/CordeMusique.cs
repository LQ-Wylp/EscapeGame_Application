using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CordeMusique : MonoBehaviour
{
    private CheckOrderCorde _CheckOrderCorde;
    public int _NbCorde;

    private void Start() 
    {
        _CheckOrderCorde = FindObjectOfType<CheckOrderCorde>();
    }

    private void OnMouseEnter() 
    {
        _CheckOrderCorde.SurvoleCorde(_NbCorde);
    }

}
