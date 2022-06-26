using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractDoor : MonoBehaviour, IInteractable
{
    // Start is called before the first frame update
    public GameObject door;
    bool isOpen;
    int cnt;
    Vector3 posPlayer;
    


    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
    }

    // Update is called once per frame
    public void Interact()
    {
        switch (door.name)
        {
            case "PorteSortie":
                ExitDoor();
                break;
            case "PorteMaisonStart":
                EnterHouseStart();
                break;
            default:
                NormalDoor();
                break;
        } 
    }

    public void EnterHouseStart()
    {
        SceneManager.LoadScene("MaisonDepart");
    }

    public void ExitDoor()
    {
        SceneManager.LoadScene("ForestScene");
    }

    public void NormalDoor()
    {
        if (isOpen == false)
        {
            cnt = 0;
            while (door.transform.rotation.eulerAngles.z < 90 && cnt < 90)
            {
                door.transform.Rotate(new Vector3(0, 0, 1));
                cnt++;
            }
            isOpen = true;

        }
        else if (isOpen == true)
        {
            door.transform.Rotate(new Vector3(0, 0, -90));
            isOpen = false;
        }
    }
}
