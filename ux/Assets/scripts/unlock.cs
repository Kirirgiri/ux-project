using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock : MonoBehaviour
{
    [SerializeField] private GameObject key;
    [SerializeField] private GameObject door;
    [SerializeField] private string doorOpen = "doorOpening";
    private void OnMouseDown()
    {
        if (key.transform.parent == GameObject.Find("Destination").transform)
        {
            Destroy(key);
            Animator anim = door.GetComponent<Animator>();
            anim.Play("doorOpening",0,0.0f);
            //anim.SetTrigger("doorOpening");
            Destroy(gameObject);
        }
    }
}
