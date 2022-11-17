using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combinationFunc : MonoBehaviour
{

    [SerializeField] private GameObject[] ingredients;

    [SerializeField] private GameObject[] fires;
    [SerializeField] private GameObject _parent;
    private bool _cauldrionCheck = true;
    private bool _tookfire = false;


    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.tag = "thrown_ingredient";
        other.gameObject.GetComponent<Outline>().enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (_cauldrionCheck)
        {
            var _thrownIngredients = 0;
            foreach (GameObject i in ingredients)
            {
                if (i.gameObject.tag == "thrown_ingredient")
                {
                    _thrownIngredients++;
                }
            }

            if (_thrownIngredients == ingredients.Length)
            {
                fires[0].SetActive(false);
                fires[1].SetActive(true);
                foreach (GameObject i in ingredients)
                {
                    Destroy(i);
                }

                _cauldrionCheck = false;
            }
        }

    }

    private void OnMouseDown()
    {
        if (!_tookfire)
        {
            if (_parent.transform.GetChild(0))
            {
                if (_parent.transform.GetChild(0).gameObject.name == "Cup_01" && fires[1].activeSelf)
                {
                    fires[2].SetActive(true);
                    fires[1].SetActive(false);
                    _tookfire = true;
                }
            }
        }
    }
}
