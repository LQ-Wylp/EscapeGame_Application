using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LanterneManager : MonoBehaviour
{
    public List<int> bonneCombi;

    public List<Lanterne> lanternes;

    public UnityEvent endEvent;

    public void Init()
    {
        for (int i=0; i<lanternes.Count; i++)
        {
            lanternes[i].etat = 0;
            lanternes[i].RefreshVisu(lanternes[i].etat);
        }
    }

    void Start()
    {
        Init();
    }

    public void CheckCombinaison()
    {
        bool success = true;

        for (int i=0; i<bonneCombi.Count; i++)
        {
            if(bonneCombi[i] != lanternes[i].etat)
            {
                success = false;
            }
        }

        if (success)
        {
            endEvent.Invoke();
        }
    }
}
