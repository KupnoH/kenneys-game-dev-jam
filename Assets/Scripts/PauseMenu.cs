using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPauseMenuOpen = false;

    
    void Update()
    {
        if (isPauseMenuOpen == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isPauseMenuOpen = true;
                pauseMenu.SetActive(true);
            }
        }
    }



    public void ClosePauseMenu()
    {
        isPauseMenuOpen = false;
    }
}
