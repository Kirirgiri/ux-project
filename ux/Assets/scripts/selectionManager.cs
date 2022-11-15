using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "selectable";
    [SerializeField] private Outline line;

    private GameObject _selection; //to keep track of selections since returning the material can be tricky
    void FixedUpdate()
    {
        if (_selection!=null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            _selection.GetComponent<Outline>().enabled = false;
            //selectionRenderer.material = defaultMaterial;
            _selection = null;
        }
        //--------previous selecting
        //var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2f, Screen.height/2f,0f));//(Input.mousePosition); may not consistently produce an accurate coordinate for the center of the screen
        
        
        RaycastHit hit;


//--------previous selecting
        //if (Physics.Raycast(ray, out hit))
        if(Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward, out hit, 7))
        {
            var selection = hit.transform.gameObject;
            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selection.GetComponent<Outline>().enabled = true;
                    selection.GetComponent<Outline>().OutlineWidth = 10f;
                }
                _selection = selection;
            }
        }
    }
}
