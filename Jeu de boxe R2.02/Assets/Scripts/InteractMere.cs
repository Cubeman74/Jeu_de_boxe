using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class InteractMere : MonoBehaviour, IInteractable
{
    public GameObject box;
    public DialogManager dialogManager;
    // Start is called before the first frame update
    public void Interact()
    {
        PlayerPrefs.SetInt("lockE", 1);
        box.SetActive(true);
        DialogData dd = new DialogData("Bonjour Claire..., j'ai besoin de ton aide pour KAWAI NEEE OUEEEE MOUNIIIIIIIIIIIIIIIIIIIIIIIIIIIRRRRRRR", "Mere");
        dialogManager.Show(dd);
        

    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            dialogManager.Click_Window();
            PlayerPrefs.SetInt("lockE", 0);
        }

            
    }
}
