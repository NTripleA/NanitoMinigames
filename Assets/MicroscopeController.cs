using UnityEngine;
using System.Collections;

public class MicroscopeController : MonoBehaviour {

    private bool hasCatalyst;
    private bool hasObject;
    private bool displayMessage;
    private string firstObjEntry;
    private string firstCatEntry;
    private string message;
    private Renderer rend;
//    public GUIText textMessage;
	public GameObject textMessage;

	// Use this for initialization
	void Start () {
        hasCatalyst = false;
        hasObject = false;
        message = "";
        displayMessage = true;
		textMessage.GetComponent<TextMesh>().fontSize = 20;
        (GameObject.FindWithTag("LeftArrow")).GetComponent<Animator>().enabled = false;
        (GameObject.FindWithTag("RightArrow")).GetComponent<Animator>().enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (hasCatalyst && hasObject)
        {
            (GameObject.FindWithTag("LeftArrow")).GetComponent<Animator>().enabled = true;
            (GameObject.FindWithTag("RightArrow")).GetComponent<Animator>().enabled = true;
            message = "The mixing process has been completed!";
        }

		textMessage.GetComponent<TextMesh>().text = message;
    }

    void OnCollisionEnter(Collision other)
    {
        if ((other.gameObject.tag == "catalyst") && hasCatalyst)
        {
            rend = GameObject.Find(firstCatEntry).GetComponent<Renderer>();
            rend.enabled = true;
            firstCatEntry = other.gameObject.name;
        }

        if ((other.gameObject.tag == "object") && hasObject)
        {
            rend = GameObject.Find(firstObjEntry).GetComponent<Renderer>();
            rend.enabled = true;
            firstObjEntry = other.gameObject.name;
        }
        
        if (other.gameObject.tag == "object")
        {
            hasObject = true;
            firstObjEntry = other.gameObject.name;
            rend = GameObject.Find(firstObjEntry).GetComponent<Renderer>();
            rend.enabled = false;
           
            if (displayMessage)
            {
                message = "Please add a catalyst!";
                displayMessage = false;
            }
        }

        if (other.gameObject.tag == "catalyst")
        {
            hasCatalyst = true;
            firstCatEntry = other.gameObject.name;
            rend = GameObject.Find(firstCatEntry).GetComponent<Renderer>();
            rend.enabled = false;
           
            if (displayMessage)
            {
                message = "Please add an object!";
                displayMessage = false;
            }
        }
    }

    void Reset()
    {
        Start();
        GameObject.Find(firstObjEntry).GetComponent<Renderer>().enabled = true;
        GameObject.Find(firstCatEntry).GetComponent<Renderer>().enabled = true;
    }
}
