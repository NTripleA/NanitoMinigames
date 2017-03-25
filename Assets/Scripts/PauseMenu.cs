using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public bool isPaused;

    public GameObject PauseMenuCanvas;
    public GameObject image;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            PauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            PauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }


	}

    public void setPaused(bool b)
    {
        isPaused = b;
    }

    public bool getIsPaused()
    {
        return isPaused;
    }

    public void Resume()
    {
        isPaused = false;
        image.SetActive(false);
    }

    public void Audio()
    {
        image.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
