using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteScarf : MonoBehaviour
{
    public float timer;

    public GameObject ScarfReward;
    public GameObject ScarfButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2 && timer <= 3)
        {
            ScarfReward.SetActive(true);
           
        }
        if (timer >= 6 && timer <= 7)
        {
            ScarfReward.SetActive(false);
            ScarfButton.SetActive(true);
        }
        if (timer >= 8)
        {
            Destroy(this);
            timer = 0;
        }


    }
}
