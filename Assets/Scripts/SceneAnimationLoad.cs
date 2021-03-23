using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneAnimationLoad : MonoBehaviour
{
    bool Animation;
    public Image _Background;
    // public float _DurationAnimation;
    Color InitialColor;
    public bool Invert = false;
    public GameObject _DesactiveThat;
    private void Start() 
    {
        Color ShowThat = _Background.color;
        ShowThat.a = 1;
        InitialColor = ShowThat;

        _Background.color = InitialColor;

        StartCoroutine(StarScene());
    }
    public IEnumerator StarScene()
    {
        float elapsed = 0.0f;
        float Alpha = 0;
        
        while (elapsed < 0.75f)
        {
            if(Invert)
            {
                Alpha = 1 - elapsed / 0.75f;
            }   
            else
            {
                Alpha = elapsed / 0.75f;
            }

            Color ShowThat = _Background.color;
            ShowThat.a = Alpha;
            _Background.color = ShowThat;

            elapsed += Time.deltaTime;
            yield return null;
        }

        if(Invert)
        {
            _DesactiveThat.SetActive(false);
        }
    }
}
