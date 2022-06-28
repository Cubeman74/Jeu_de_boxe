﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class loupPlayerTrig : MonoBehaviour
{
    [SerializeField] GameObject panelGO;
    private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;
    private bool m_Paused;
    [SerializeField] public GameObject pauseMenu;
    [SerializeField] public GameObject perso;
    // Start is called before the first frame update
    void Start()
    {

    }


    void Awake()
    {
        pauseMenu.SetActive(false);
        m_Paused = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Loup")
        {
            Debug.Log("GAME OVER");
            panelGO.active = true;
            perso.GetComponentInChildren<FirstPersonController>().enabled = false;
            m_TimeScaleRef = Time.timeScale;
            Time.timeScale = 0f;
            m_VolumeRef = AudioListener.volume;
            AudioListener.volume = 0f;
            m_Paused = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
