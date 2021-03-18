using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarfCode : MonoBehaviour
{
    public GameObject CamScarf;
    public GameObject CardScarf;

    public GameObject CardKitsune;
    public GameObject KitsuneWithScarf;
    public float HaveScarf = 0;
    public float HaveWin = 0;
    string Name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HaveWin == 1)
        {
            CamScarf.SetActive(false);
            CardKitsune.SetActive(false);
            KitsuneWithScarf.SetActive(true);
            CardScarf.SetActive(false);
            CardKitsune.SetActive(false);
        }
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))
            {
                Name = Hit.transform.name;
                switch (Name)
                {
                    case "scarf":
                        HaveScarf = 1;
                        CamScarf.SetActive(true);
                        CardScarf.SetActive(false);
                        break;

                    case "Kitsune":
                        if (HaveScarf == 1)
                        {
                            CamScarf.SetActive(false);
                            CardKitsune.SetActive(false);
                            KitsuneWithScarf.SetActive(true);
                            HaveWin = 1;
                            HaveScarf = 0;
                        }
                        break;
                    default:
                        break;
                     
                }
            }
        }
    }
}
