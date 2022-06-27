using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    public Text t1;
    public Text t2;
    public Text t3;
    public GameObject ingredient;
    public int ingredientCount;


    // Update is called once per frame
    void Update()
    {
        switch (PlayerPrefs.GetInt("lvlTask"))
        {
            case 0:
                t1.text = " - Parler à maman";
                t2.text = "";
                t3.text = "";
                break;
            case 1:
                t1.text = " - Récupérer pain";
                t2.text = " - Récupérer lait";
                t3.text = " - Récupérer oeufs";
                break;
            case 2:
                t1.text = " - Aller chez Grand-Mère";
                t2.text = "";
                t3.text = "";
                break;
            default:
                break;
        }

        if (ingredientCount == 3)
            PlayerPrefs.SetInt("lvlTask", 2);
    }

    public void TalkMaman()
    {
        t1.color = Color.green;
    }

    public void lvlUp()
    {
        PlayerPrefs.SetInt("lvlTask", 1);
        t1.color = Color.yellow;
        t2.color = Color.yellow;
        t3.color = Color.yellow;
    }

    public void Pain()
    {
        t1.color = Color.green;
        ingredientCount++;
    }
    public void Lait()
    {
        t2.color = Color.green;
        ingredientCount++;
    }
    public void Oeuf()
    {
        t3.color = Color.green;
        ingredientCount++;
    }
}
