using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {

    public PlayerController player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if(gameObject.name == "Walls")
        {
            player.SendMessage("setNoTouch");
        }
        else if(gameObject.name == "Shelf Tech")
        {
            player.SendMessage("setShelf");
        }
        else if(gameObject.name == "Multiple Monitor PC")
        {
            player.SendMessage("setDesk");
        }
        else if(gameObject.name == "SettingsButton")
        {
            player.SendMessage("setSettings");
        }
    }
}
