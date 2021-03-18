using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARGrissage : MonoBehaviour
{
    public static bool _ActivedAR;
    public GameObject _ButtonAR;
    
    void Update()
    {
        if(_ActivedAR)
        {
            _ButtonAR.SetActive(true);
            Destroy(gameObject);
        }
    }
}
