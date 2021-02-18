using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeManager : MonoBehaviour
{
    private static CodeManager _CodeManager = null;

    public static CodeManager Instance()
    {
        return _CodeManager;
    }
    private void Awake() 
    {
        if(_CodeManager == null)
        {
            _CodeManager = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
    }
}
