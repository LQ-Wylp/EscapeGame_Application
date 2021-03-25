using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedBackErrorTextColor : MonoBehaviour
{
    public Color _ErrorColor;
    private Color _InitialColor;
    private Text _MyText;

    private void Start() 
    {
        _MyText = GetComponent<Text>();
        _InitialColor = _MyText.color;
    }
    public IEnumerator ChangeColor(float duration)
    {
        _MyText.color = _ErrorColor;

        yield return new WaitForSeconds(duration);

        _MyText.color = _InitialColor;
    }

    public void LaunchFeedBack(float duration)
    {
        StopAllCoroutines();
        StartCoroutine(ChangeColor(duration));
    }
}
