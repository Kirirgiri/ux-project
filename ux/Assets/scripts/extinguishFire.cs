using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extinguishFire : MonoBehaviour
{
    [SerializeField] private GameObject cupFire;
    [SerializeField] private GameObject curseFire;
    [SerializeField] private GameObject havingCup;

    private void OnMouseDown()
    {
        if (havingCup.transform.GetChild(0))
        {
            if (havingCup.transform.GetChild(0).name == "Cup_01" && cupFire.activeSelf)
            {
                GameObject.Find("Key_Rusty").tag = "selectable";
                Destroy(cupFire);
                Destroy(curseFire);
                Destroy(gameObject);
            }
        }
    }
}
