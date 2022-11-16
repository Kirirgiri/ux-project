using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeInCursor : MonoBehaviour
{
    [SerializeField] private Sprite sprite1;
    [SerializeField] private Sprite sprite2;
    [SerializeField] private GameObject selectionManager;
    private Image i;
    
    // Start is called before the first frame update
    void Start()
    {
        i = GetComponent<Image>();
        i.sprite = sprite1;
    }

    public void changeCursor()
    {
        i.overrideSprite = sprite2;
        i.GetComponent<Image>().color = new Color(255,0,0,255);
    }
    public void changeCursor2()
    {
        i.overrideSprite = sprite1;
        i.GetComponent<Image>().color = new Color(255,255,255,255);
    }

    // Update is called once per frame
    void Update()
    {
        var _selection = selectionManager.GetComponent<selectionManager>().seen;
        if (_selection)
        {
            changeCursor();
        }
        else
        {
            changeCursor2();
        }
    }
}
