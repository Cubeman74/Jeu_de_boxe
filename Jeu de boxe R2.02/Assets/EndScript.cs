using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;
public class EndScript : MonoBehaviour, IInteractable
{
    public DialogData dd;
    public DialogManager dialogManager;
    private GameObject ui;
    private GameObject player;
    void Start()
    {
        PlayerPrefs.SetInt("ddGM", 0);
        player = GameObject.FindGameObjectWithTag("Player");
        ui = GameObject.FindGameObjectWithTag("UI");
    }
    public void Interact()
    {
        PlayerPrefs.SetInt("lockE", 1);
        if (PlayerPrefs.GetInt("ddGM") == 0)
        {
            dd = new DialogData("Ohhhh Merci claire :D", "GM");
            dialogManager.Show(dd);
            PlayerPrefs.SetInt("ddGM", 1);
        }
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(1) && PlayerPrefs.GetInt("ddGM") == 0)
        {
            Destroy(ui);
            Destroy(player);
            SceneManager.LoadScene("Credits");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }


    }
}
