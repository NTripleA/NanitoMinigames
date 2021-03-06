﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour {

    private bool isMain;
    private bool isDesk;
    private bool isShelf;
    private bool isJournal;

    public GameObject mainCam;
    public GameObject deskCam;
    public GameObject shelfCam;
    public GameObject journal;

	// Use this for initialization
	void Start () {

        isMain  =  true;
        isDesk  = false;
        isShelf = false;
        isJournal = false;


        mainCam.SetActive(true);
        deskCam.SetActive(false);
        deskCam.SetActive(false);
        journal.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {
            isDesk  = false;
            isMain  = false;
            isShelf =  true;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            isDesk  =  true;
            isMain  = false;
            isShelf = false;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            isDesk  = false;
            isMain  =  true;
            isShelf = false;
        }

        if (isMain)
        {
            mainCam.SetActive(true);
            deskCam.SetActive(false);
            shelfCam.SetActive(false);
            journal.SetActive(false);
        }

        if (isDesk)
        {
          //  mainCam.SetActive(false);
            deskCam.SetActive(true);
            journal.SetActive(false);
            shelfCam.SetActive(false);
        }

        if (isShelf)
        {
          //  mainCam.SetActive(false);
            deskCam.SetActive(false);
            journal.SetActive(false);
            shelfCam.SetActive(true);
            
        }

        if (isJournal)
        {
            deskCam.SetActive(false);
            shelfCam.SetActive(false);
            journal.SetActive(true);
        }
    }

    public void setDeskCam()
    {
        isDesk  =  true;
        isMain  = false;
        isShelf = false;
        isJournal = false;
    }

    public void setShelfCam()
    {
        isDesk  = false;
        isMain  = false;
        isShelf =  true;
        isJournal = false;
    }

    public void setMainCam()
    {
        isDesk  = false;
        isMain  =  true;
        isShelf = false;
        isJournal = false;
    }

    public void setJournalCam()
    {
        isDesk = false;
        isMain = false;
        isShelf = false;
        isJournal = true;
    }

    public bool getMainCam()
    {
        return isMain;
    }

    public bool getDeskCam()
    {
        return isDesk;
    }
}
