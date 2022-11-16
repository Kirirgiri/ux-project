using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combinationFunc : MonoBehaviour
{

    [SerializeField] private GameObject[] ingredients;

    [SerializeField] private GameObject[] fires;


    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.tag = "thrown_ingredient";
        var _thrownIngredients = 0;
        foreach (GameObject i in ingredients)
        {
            if (i.gameObject.tag == "thrown_ingredient")
            {
                _thrownIngredients++;
                Debug.Log(i.name);
            }
        }

        if (_thrownIngredients == ingredients.Length)
        {
            fires[0].SetActive(false);
            fires[1].SetActive(true);
        }
    }
    
}
