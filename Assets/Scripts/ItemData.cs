using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class ItemData : MonoBehaviour {

    public bool picked = false;
    public Inventory inventory;
    public Sprite obj;

    public GameObject crystals;

	// Use this for initialization
	void Start () {
	
	}
	

    public ItemData Clone()
    {
        ItemData clone = new ItemData();
        clone.tag = this.tag;
        clone.transform.position = this.transform.position;
        clone.transform.localScale = this.transform.localScale;

        return clone;
    }

    void Update()
    {
      
    }
    void OnMouseDown()
    {

        if (!crystals.activeSelf)
        {
            if (!inventory.isUsed()) //so we won't have more than one item being picked
            {
                this.gameObject.SetActive(false);
                picked = true;
                inventory.changeSprite(obj, this);
            }
        }
        
    }


}
