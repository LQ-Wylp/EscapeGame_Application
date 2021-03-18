using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBall : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Instantiates this ball prefab in front of the AR Camera.")]
    GameObject m_BallPrefab;

    public GameObject spawnedBall;

    [SerializeField] GameObject ARCam;

    public Transform spawnBall;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                spawnedBall = Instantiate(m_BallPrefab);
                spawnedBall.transform.position = spawnBall.transform.position;
                spawnedBall.transform.parent = ARCam.transform;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                spawnedBall.transform.parent = null;
            }
        }
    }
}
