using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartePC : MonoBehaviour
{

    public static float IsOnPC = 0;
    public Image buttonsprite;

    public Image buttonspriteX;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        buttonsprite.color = new Color(buttonsprite.color.r, buttonsprite.color.g, buttonsprite.color.b, 0.6f);

        buttonspriteX.color = new Color(buttonspriteX.color.r, buttonspriteX.color.g, buttonspriteX.color.b, 1f);
        IsOnPC = 1;
        CartPhysique.IsNotPC = 0;
        DontDestroyOnLoad(gameObject);
    }
}
