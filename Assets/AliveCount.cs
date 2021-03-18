using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveCount : MonoBehaviour
{
    public float timer;

    public GameObject ScarfReward;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 4 && timer <= 5)
        {
            ScarfReward.SetActive(false);
            timer = 0;

        }
    }
}
