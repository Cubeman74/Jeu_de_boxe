using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.UI;

public class InteractMere : MonoBehaviour, IInteractable
{
    public GameObject box;
    public DialogManager dialogManager;
    public DialogData dd;
    public TaskManager tm;
    // Start is called before the first frame update
    public void Interact()
    {
        
        PlayerPrefs.SetInt("lockE", 1);       
        box.SetActive(true);
        if(PlayerPrefs.GetInt("ddMere") == 0)
        {
            dd = new DialogData("Bonjour Claire..., j'ai besoin de ton aide pour que tu ailles chez grand-mère pour lui ramener son dinner. Mais j'ai oublié de faire les courses magiques...", "Mere");
            tm.TalkMaman();
        }            
        else
            dd = new DialogData("Il faut que tu trouves du /color:#caff69/pain/color:#ffffff/, du /color:#caff69/lait/color:#ffffff/ et du /color:#caff69/beurre/color:#ffffff/. Ah oui et fait /color:#a3002e/attention aux loups dehors !", "Mere");
        dialogManager.Show(dd);
        

    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(1) && PlayerPrefs.GetInt("ddMere") == 0)
        {
            tm.lvlUp();
            PlayerPrefs.SetInt("ddMere", 1);
            dialogManager.Click_Window();           
            dd = new DialogData("Il faut que tu trouves du /color:#caff69/pain/color:#ffffff/, du /color:#caff69/lait/color:#ffffff/ et du /color:#caff69/beurre/color:#ffffff/. Ah oui et fait /color:#a3002e/attention aux loups dehors !", "Mere");
            dialogManager.Show(dd);
            
        }
        else if (Input.GetMouseButtonDown(1))
        {
            dialogManager.Click_Window();
            PlayerPrefs.SetInt("lockE", 0);
        }

            
    }
}
