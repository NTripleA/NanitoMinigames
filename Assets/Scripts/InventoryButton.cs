using UnityEngine;
using System.Collections;

public class InventoryButton : MonoBehaviour {

    public Inventory inv;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void BeenClicked()
    {
        Debug.Log("AQUIASDA");
        inv.ReturnFromWhenceYouCame();
    }
}
