using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class MainMenuFunctions : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public GameObject interfaceGO;
    [SerializeField] public GameObject player;
    private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;
    private bool m_Paused;

    void Start()
    {
        Application.targetFrameRate = 240;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Credits() 
    {
        SceneManager.LoadScene("Credits");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MaisonDepart");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Restart()
    {
        interfaceGO.SetActive(false);
        SceneManager.LoadScene("MaisonDepart");
        player.GetComponentInChildren<CharacterController>().enabled = false;
        player.transform.position = new Vector3(-4.277f, 2f, -1.47f);
        player.GetComponentInChildren<CharacterController>().enabled = true;

        player.GetComponentInChildren<FirstPersonController>().enabled = true;
        m_TimeScaleRef = Time.timeScale;
        Time.timeScale = 1f;
        m_VolumeRef = AudioListener.volume;
        AudioListener.volume = 1f;
        m_Paused = false;
        Cursor.visible = false;
        PlayerPrefs.SetInt("lockE", 0);
        PlayerPrefs.SetInt("lvlTask", 1);
        PlayerPrefs.SetString("ingredient", "");
    }
}
