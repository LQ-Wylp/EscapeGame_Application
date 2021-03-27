using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBall : MonoBehaviour
{
    public AudioSource coinsound;
    public Score score;
    public GameObject CoinButton;
    public GameObject CoinReward;

    private void Start()
    {
        score = FindObjectOfType<Score>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball" && score.scoreValue < 3)
        {
            coinsound.Play();
            score.scoreValue++;
        }

    }

    private void Update()
    {
        if (score .scoreValue >= 3)
        {

            CoinButton.SetActive(true);
            CoinReward.SetActive(true);
        }
    }
}
