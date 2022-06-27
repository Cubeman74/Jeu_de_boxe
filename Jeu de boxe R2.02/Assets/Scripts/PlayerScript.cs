using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float rayRange = 4;
    public GameObject interactText;

    private void Start()
    {
        PlayerPrefs.SetInt("lockE", 0);
        PlayerPrefs.SetInt("ddMere", 0);
        PlayerPrefs.SetInt("lvlTask", 0);
        PlayerPrefs.Save();
    }
    void Update()
    {
        CastRay();
        
    }

    void CastRay()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, rayRange);
        
        if (hit && hitInfo.transform.gameObject.tag == "InteractObject" && PlayerPrefs.GetInt("lockE") == 0)
        {
            interactText.SetActive(true);
            GameObject hitObject = hitInfo.transform.gameObject;
            if (Input.GetKeyDown(KeyCode.E))
            {
                hitObject.GetComponent<IInteractable>().Interact();
            }
        }
        else
        {
            interactText.SetActive(false);
        }
    }
}