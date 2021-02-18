using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisqueAmovible : MonoBehaviour
{
    public float _SpeedRotation;
    private Vector3 _CurrentMousePositon;
    private Vector3 _DeltaMousePositon;
    private Vector3 _LastMousePositon;

    private bool _Pressed;

    private float _WidthScreenSize; // X
    private float _HeightScreenSize; // Y

    private bool _MouseAtTop;
    private bool _MouseAtRight;

    private float _RotationZ;

    public bool _Succes;
    public float _MargeErreur;

    private void Start() 
    {
        _WidthScreenSize = Screen.width;
        _HeightScreenSize = Screen.height;

        float Rand = Random.Range(0f,360f);
        transform.Rotate(0,0,Rand);
    }

    void Update()
    {
        _CurrentMousePositon = Input.mousePosition;
        _DeltaMousePositon = _CurrentMousePositon - _LastMousePositon;
        _LastMousePositon = _CurrentMousePositon;

        // Detecte où est la souris avant de commencer à bouger l'élément
        if(_CurrentMousePositon.x >=  _WidthScreenSize/2)
        {
            _MouseAtRight = true;
        }
        else
        {
            _MouseAtRight = false;
        }

        if(_CurrentMousePositon.y >=  _HeightScreenSize/2)
        {
            _MouseAtTop = true;
        }
        else
        {
            _MouseAtTop = false;
        }
        

        if(_Pressed)
        {
            float Angle = 0;

            if(_MouseAtTop)
            {
                Angle += _DeltaMousePositon.x * _SpeedRotation * Time.deltaTime  * -1;
            }
            else
            {
                Angle += _DeltaMousePositon.x * _SpeedRotation * Time.deltaTime;
            }

            if(_MouseAtRight)
            {
                Angle += _DeltaMousePositon.y * _SpeedRotation * Time.deltaTime;
            }
            else
            {
                Angle += _DeltaMousePositon.y * _SpeedRotation * Time.deltaTime * -1;
            }
            

            transform.Rotate(0,0,Angle);

        }

        _RotationZ = transform.rotation.z;

        if(_MargeErreur > _RotationZ && _RotationZ > -_MargeErreur)
        {
            _Succes = true;
        }
        else
        {
            _Succes = false;
        }

    }

    public void OnMouseDown() 
    {
        _Pressed = true;
    }
    public void OnMouseUp() 
    {
        _Pressed = false;
    }

}
