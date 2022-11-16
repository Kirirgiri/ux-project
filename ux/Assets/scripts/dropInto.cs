using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropInto : MonoBehaviour
{
    [SerializeField] private Transform dropIntoDest;

    private void OnMouseDown()
    {
        GameObject[] objects;
        objects = GameObject.FindGameObjectsWithTag("ingredient");
        foreach (GameObject i in objects)
        {
            i.GetComponent<pickUp>().ha = false;
            i.transform.position = dropIntoDest.position;
        }
    }
}
