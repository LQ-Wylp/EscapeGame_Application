using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineManager : MonoBehaviour
{
    private static MachineManager _MachineManager = null;

    public static MachineManager Instance()
    {
        return _MachineManager;
    }
    private void Awake() 
    {
        if(_MachineManager == null)
        {
            _MachineManager = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
    }
}
