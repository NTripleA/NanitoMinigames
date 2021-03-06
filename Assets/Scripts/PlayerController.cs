﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;

    public CameraSwitcher camSwitch;

    public GameObject shelf;
    public GameObject desk;
    public GameObject settings;
    public PauseMenu pauseMenu;

    public Transform shelfPos;
    public Transform deskPos;

    private RaycastHit hit;
    private bool goShelf;
    private bool goDesk;

    private Rigidbody2D rb;
    private Animator anim;

    private float sleepTimer;
    private float sleepWaitTime;

    public GameObject crystals;

	// Use this for initialization
	void Start () {

        goShelf = false;
        goDesk = false;

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        sleepWaitTime = 5f;
        sleepTimer = sleepWaitTime;
	}
	
	// Update is called once per frame
	void Update () {
        if (camSwitch.getMainCam())
        {
            crystals.SetActive(true);
        }
        else
        {
            crystals.SetActive(false);
        }
       /* if (Input.GetMouseButtonDown(0) && camSwitch.getMainCam())
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                if(shelf == hit.collider.gameObject)
                {
                    setShelf();
                }
                else if(desk == hit.collider.gameObject)
                {
                    setDesk();
                }
                else if(settings == hit.collider.gameObject)
                {
                    setSettings();
                }
            }
            else
            {
                setNoTouch();
            }
        }
        */
        if (goShelf)
        {
            rb.velocity = new Vector2(-moveSpeed, 0);
            transform.localScale = new Vector3(-.6f, .6f, 1);

            if (transform.position.x <= shelfPos.position.x)
            {
                
                goShelf = false;
                camSwitch.setShelfCam();
                sleepTimer = sleepWaitTime;
                
            }
        }
        else if (goDesk)
        {
            rb.velocity = new Vector2(moveSpeed, 0);
            transform.localScale = new Vector3(.6f, .6f, 1);

            if(transform.position.x >= deskPos.position.x)
            {
                goDesk = false;
                camSwitch.setDeskCam();
                sleepTimer = sleepWaitTime;
            }
        }
        else
        {
            goShelf = false;
            goDesk = false;
            rb.velocity = new Vector2(0, 0);
        }

        sleepTimer -= Time.deltaTime;
        if(sleepTimer < 0)
        {
            anim.SetBool("Sleep", true);
        }
        else
        {
            anim.SetBool("Sleep", false);
        }
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
    }

    public void setShelf()
    {
        goShelf = true;
        goDesk = false;
    }

    public void setDesk()
    {
        goShelf = false;
        goDesk = true;
    }

    public void setSettings()
    {
        pauseMenu.setPaused(true);
    }

    public void setNoTouch()
    {
        
        goShelf = false;
        goDesk = false;
        sleepTimer = sleepWaitTime;

        if (!camSwitch.getMainCam())
        {
            camSwitch.setMainCam();
        }
        
    }

    public void setJournal()
    {
        if(camSwitch.getDeskCam())
        {
            Debug.Log("llegue");
            camSwitch.setJournalCam();
        }
    }
}
