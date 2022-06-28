using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientScript : MonoBehaviour, IInteractable
{
    public GameObject ingredient;

    void Start()
    {
    }
    public void Interact()
    {
        switch (ingredient.name)
        {
            case "Pain":
                Destroy(ingredient);
                PlayerPrefs.SetString("ingredient", gameObject.name);
                break;
            case "Lait":
                Destroy(ingredient);
                PlayerPrefs.SetString("ingredient", gameObject.name);
                break;
            default:
                break;
        }
    }

}
