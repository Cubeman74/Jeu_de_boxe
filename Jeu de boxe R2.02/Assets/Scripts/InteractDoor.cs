using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractDoor : MonoBehaviour, IInteractable
{
    // Start is called before the first frame update
    public GameObject door;
    bool isOpen;
    int cnt;


    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
    }

    // Update is called once per frame
    public void Interact()
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
