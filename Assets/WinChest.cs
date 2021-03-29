using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WinChest : MonoBehaviour
{
    
    public UnityEvent EventEnd;

    public GameObject Bouton1;
    public GameObject Bouton2;
    public GameObject Bouton3;
    public GameObject Bouton4;
    public GameObject Bouton5;
    public GameObject Bouton6;

    public float timer = 0; 

    // Start is called before the first frame update
    void Start()
    {
        Bouton1.SetActive(false);
        Bouton2.SetActive(false);
        Bouton3.SetActive(false);
        Bouton4.SetActive(false);
        Bouton5.SetActive(false);
        Bouton6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2)
        {
            EventEnd.Invoke();
        }
    }
}
