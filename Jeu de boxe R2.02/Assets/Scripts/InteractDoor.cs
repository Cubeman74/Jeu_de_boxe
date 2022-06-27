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
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
        player = GameObject.FindGameObjectWithTag("Player");
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
            case "PorteMoulin":
                EnterMill();
                break;
            default:
                NormalDoor();
                break;
        } 
    }

    public void EnterHouseStart()
    {
        player.GetComponentInChildren<CharacterController>().enabled = false;
        player.transform.position = new Vector3(6, 1, 0.5f);
        player.GetComponentInChildren<CharacterController>().enabled = true;
        SceneManager.LoadScene("MaisonDepart");       
    }
    public void EnterMill()
    {
        player.GetComponentInChildren<CharacterController>().enabled = false;
        player.transform.position = new Vector3(-3, 2.5f, 0);
        player.GetComponentInChildren<CharacterController>().enabled = true;
        SceneManager.LoadScene("Niveau1");
        
    }

    public void ExitDoor()
    {
        player.GetComponentInChildren<CharacterController>().enabled = false;
        player.transform.position = new Vector3(-4, 1.5f, -12);
        player.GetComponentInChildren<CharacterController>().enabled = true;
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
