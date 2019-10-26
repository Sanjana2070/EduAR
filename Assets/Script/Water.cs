using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water : MonoBehaviour
{
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject WaterModel;
    public GameObject OxygenModel, HydrogenLeft, HydrogenRight;
    public Button CovBond, ExpDes;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        WaterModel.SetActive(false);
        float distance1 = Vector3.Distance(box1.transform.position, box2.transform.position);
        float distance2 = Vector3.Distance(box3.transform.position, box4.transform.position);
        CovBond.gameObject.SetActive(false);
        ExpDes.gameObject.SetActive(false);
        

        if (distance1 > 0.1 || distance2 > 0.1)
        {
            OxygenModel.SetActive(true);
            HydrogenLeft.SetActive(true);
            HydrogenRight.SetActive(true);
            CovBond.gameObject.SetActive(false);
            ExpDes.gameObject.SetActive(false);
            WaterModel.SetActive(false);
            //Add canvas image/animation of telling them to join the three

        }
        else if (0.1 >= distance1 && 0.1 >= distance2)
        {
            WaterModel.SetActive(true);
            OxygenModel.SetActive(false);
            HydrogenLeft.SetActive(false);
            HydrogenRight.SetActive(false);
            // set active 2 buttons: 1 for H2O formation guide
            //2nd button for Covalent bond explanation
            CovBond.gameObject.SetActive(true);
            ExpDes.gameObject.SetActive(true);
        }

        Debug.Log(distance1);
    }
}
