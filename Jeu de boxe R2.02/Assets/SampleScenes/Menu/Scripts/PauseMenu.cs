using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenu : MonoBehaviour
{
	private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;
    private bool m_Paused;
    public GameObject pauseMenu;
    public GameObject perso;


    void Awake()
    {
        pauseMenu.SetActive(false);
        m_Paused = false;
    }


    private void MenuOn ()
    {
        perso.GetComponentInChildren<FirstPersonController>().enabled = false;
        m_TimeScaleRef = Time.timeScale;
        Time.timeScale = 0f;
        m_VolumeRef = AudioListener.volume;
        AudioListener.volume = 0f;
        m_Paused = true;
        pauseMenu.SetActive(true);
    }


    public void MenuOff ()
    {
        perso.GetComponentInChildren<FirstPersonController>().enabled = true;
        Time.timeScale = m_TimeScaleRef;
        AudioListener.volume = m_VolumeRef;
        m_Paused = false;
        pauseMenu.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }



	void Update()
	{
        if (Input.GetKeyDown(KeyCode.Escape) && !m_Paused)
            MenuOn();
        else if (Input.GetKeyDown(KeyCode.Escape) && m_Paused)
            MenuOff();
    }

}
