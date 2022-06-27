using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public GameObject player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Start is called before the first frame update
    void Start()
    {
        
        switch (PlayerPrefs.GetString("posPlayer"))
        {
            case "EnterHouseStart":
                player.transform.position = new Vector3();
                break;
            case "EnterMill":
                player.transform.position = new Vector3(3, 2.5f, -0.5f);
                break;
            case "ExitHouse":
                player.transform.position = new Vector3(-4, 1.5f, -12);
                break;
            default:
                player.transform.position = new Vector3();
                break;
        }
    }

}
