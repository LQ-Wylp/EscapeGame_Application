using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterne : MonoBehaviour
{
    public int etat = 0;

    public List<GameObject> luminosite;

    public LanterneManager manager;

    public void RefreshVisu(int index)
    {
        for (int i=0; i<luminosite.Count; i++)
        {
            luminosite[i].SetActive(false);
        }

        luminosite[index].SetActive(true);

    }

    public void OnClick()
    {
        etat += 1;

        if (etat >= luminosite.Count)
        {
            etat = 0;
        }

        RefreshVisu(etat);

        manager.CheckCombinaison();

    }
}
