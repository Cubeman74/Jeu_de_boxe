using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientScript : MonoBehaviour, IInteractable
{
    public TaskManager tm;
    public GameObject ingredient;

    void Start()
    {

    }
    public void Interact()
    {
        switch (ingredient.name)
        {
            case "Pain":
                ingredient.SetActive(false);
                tm.Pain();
                break;
            default:
                break;
        }
    }

}
