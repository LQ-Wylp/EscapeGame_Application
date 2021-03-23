using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shaker : MonoBehaviour
{

    Vector3 originalPos;
    public float _Duration;
    public float _Magnitude;

    private void Start()
    {
        originalPos = transform.localPosition;
    }

    public void LaunchShake()
    {
        StartCoroutine(Shake(_Duration,_Magnitude));
    }

    public IEnumerator Shake(float duration, float magnitude)
    {
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;
    }
}

