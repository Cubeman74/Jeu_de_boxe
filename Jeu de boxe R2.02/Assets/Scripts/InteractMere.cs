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
        box.SetActive(true);
        DialogData dd = new DialogData("SUUUUUUUUUUU/color:#1fcbfc/UUUUUUUUUUUU/close/");
        dialogManager.Show(dd);
    }
}
