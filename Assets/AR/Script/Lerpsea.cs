using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerpsea : MonoBehaviour
{
    public Vector3 a;
    public Vector3 b;
    [Range(0, 1)]
    public float pourcentage;
    public float speed;

   
    public AnimationCurve curve;

    private void Start()
    {
        a += transform.position;
        b += transform.position;
    }

    void Update()

    {
       //effectue un lerp entre deux positions (transition linéaire)
            pourcentage += Time.deltaTime *speed;
       
        
        float easing = curve.Evaluate(pourcentage);

        transform.position = Vector3.Lerp(a, b, easing);
        if (pourcentage >= 1)
        {
            Destroy(this);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(a, Vector3.one * 0.5f);
        Gizmos.DrawCube(b, Vector3.one * 0.5f);
    }
}

