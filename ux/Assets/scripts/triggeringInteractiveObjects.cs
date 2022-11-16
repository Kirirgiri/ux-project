using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggeringInteractiveObjects : MonoBehaviour
{
    [SerializeField] private Outline line;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "selectable")
        {
            other.GetComponent<Outline>().enabled = true;
            other.GetComponent<Outline>().OutlineWidth = 10f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "selectable")
        {
            other.GetComponent<Outline>().enabled = false;
        }
    }
}
