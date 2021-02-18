using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurificationTemple : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;

    public Quaternion attitude;
    public Text _Debugattitude;


    private void Start() 
    {
        gyroEnabled = EnableGyro();

    }

    private bool EnableGyro()
    {
        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyroEnabled = true;
            return true;
        }
        return false;
    }

    void Update()
    {
        attitude = gyro.attitude;
        _Debugattitude.text = attitude.ToString();

    }
}
