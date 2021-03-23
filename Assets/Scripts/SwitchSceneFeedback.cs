using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SwitchSceneFeedback : MonoBehaviour
{
     // public float _DurationAnimation;
    public UnityEvent _LaunchAnimation;

    public IEnumerator LoadSceneWithFeedBack(string NameScene)
    {
        float elapsed = 0.0f;

        
        while (elapsed < 0.75f)
        {
            
            elapsed += Time.deltaTime;
            yield return null;
        }

        SceneManager.LoadScene(NameScene);
    }

    public void LoadScene(string NameScene)
    {
        _LaunchAnimation.Invoke();
        StartCoroutine(LoadSceneWithFeedBack(NameScene));
    }
}
