using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TempleOpen : MonoBehaviour
{
    public UnityEvent _EventEnd;

    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= 3)
        {
            _EventEnd.Invoke();
        }
    }
}
