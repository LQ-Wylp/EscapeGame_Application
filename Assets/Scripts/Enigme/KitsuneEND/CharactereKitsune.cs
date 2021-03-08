using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactereKitsune : MonoBehaviour
{
    public bool _Selected;
    private void OnMouseDown() 
    {
        _Selected = !_Selected;
        ActualiseSelect();
    }

    private void ActualiseSelect()
    {
        if(_Selected)
        {
            //Montrer que c'est selectionné
        }
        else
        {
            //Montrer que c'est déselectionné
        }
    }
    
}
