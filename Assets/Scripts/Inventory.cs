using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

[Serializable]
public class Inventory : MonoBehaviour {

    public Sprite oldsprite; //this will be the default sprite, when there is no item on the inventory slot

    private bool used = false; //This is so the user can't click two items and override it
    public Button button; //The button = the inventory slot
    private ItemData it; //The current item on the inventory slot
   

    // Use this for initialization
    void Start () {

        
        button.gameObject.SetActive(false); //the button starts as inactive since there the user has not clicked an item

    }

    // Update is called once per frame
    void Update () {
	
     
	}
    /*
    This is to change the sprite from the default to the current item's
    @param newsprite - the sprite to replace
    @param item - the item which is currently on the item slot 
    */
    public void changeSprite(Sprite newsprite, ItemData item)
    {
     
        it = item;
        GetComponent<Image>().sprite = newsprite;
        button.gameObject.SetActive(true);
        used = true;
    }

    /*
     This disables the button and returns the object to the shelf
         */

    public void ReturnFromWhenceYouCame()
    {
        Debug.Log("AQUI");
        it.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
        GetComponent<Image>().sprite = oldsprite;
        used = false;
    }

    public bool isUsed()
    {
        return used;
    }

    /*
     * Returns the name of the current object in the inventory slot
     */

    public String getObjectName()
    {
        if(it == null)
        {
            return "";
        }
        else
        {
            return it.gameObject.name;
        }
    
    }
    
    
}
