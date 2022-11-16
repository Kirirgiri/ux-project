using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class selectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "selectable";
    //[SerializeField] private Outline line;
    public bool seen;

    private GameObject _selection; //to keep track of selections since returning the material can be tricky
    void FixedUpdate()
    {
        if (_selection!=null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            //_selection.GetComponent<Outline>().enabled = false;
            seen = false;
            _selection = null;
        }


        RaycastHit hit;

        
        //if (Physics.Raycast(ray, out hit))
        if(Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward, out hit, 7))
        {
            var selection = hit.transform.gameObject;
            if (selection.CompareTag(selectableTag))
            {
                //var selectionRenderer = selection.GetComponent<Renderer>();
                //if (selectionRenderer != null)
                //{
                  //  selection.GetComponent<Outline>().enabled = true;
                    //selection.GetComponent<Outline>().OutlineWidth = 10f;
                //}
                seen = true;
                _selection = selection;
            }
        }
    }
}
