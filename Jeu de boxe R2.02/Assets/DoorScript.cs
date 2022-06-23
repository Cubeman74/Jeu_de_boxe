using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey(KeyCode.K))
            door.transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
    }
}
