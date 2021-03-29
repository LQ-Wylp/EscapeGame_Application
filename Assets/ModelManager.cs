using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MonoBehaviour
{

    public GameObject Kitsune;

    public GameObject Coupelle;
    // Start is called before the first frame update
    void Start()
    {


        if (CartePC.IsOnPC == 1)
        {
            Kitsune.transform.localRotation = Quaternion.Euler(-90, 180, 0);
            Kitsune.transform.localPosition = new Vector3(0, 0.054f, -0.074f);


            Coupelle.transform.localRotation = Quaternion.Euler(0, 0, 0);
            Coupelle.transform.localPosition = new Vector3(0, 0.0541f, -0.1081f);

        }

        if (CartPhysique.IsNotPC == 1)
        {

            Kitsune.transform.localRotation = Quaternion.Euler(0, 180, 0);
            Kitsune.transform.localPosition = new Vector3(0, -0.016f, 0);

            Coupelle.transform.localRotation = Quaternion.Euler(-90, 0, 0);
            Coupelle.transform.localPosition = new Vector3(0, 0.0018f, -0.0056f);
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
