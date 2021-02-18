using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndiceManager : MonoBehaviour
{
    private static IndiceManager _IndiceManager = null;

    public static IndiceManager Instance()
    {
        return _IndiceManager;
    }
    private void Awake() 
    {
        if(_IndiceManager == null)
        {
            _IndiceManager = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
    }
}
