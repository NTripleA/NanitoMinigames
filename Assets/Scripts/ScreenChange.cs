using UnityEngine;
using System.Collections;

public class ScreenChange : MonoBehaviour {

	//Buttons
	public GameObject triviaButton;
	public GameObject select1;
	public GameObject select2;
	public GameObject backPage1;
	public GameObject nextPage1;
	public GameObject backPage2;
	public GameObject journal;

	//Windows
	public GameObject home;
	public GameObject trivia;
	public GameObject correct;
	public GameObject wrong;
	public GameObject page1;
	public GameObject page2;

	//Who's active?
	public static bool homePage = true;
	public static bool pageOne = false;
	public static bool pageTwo = false;
	public static bool triviaPage = false;
	public static bool correctPage = false;
	public static bool wrongPage = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		check2DObjectClicked ();

		home.SetActive (homePage);
		trivia.SetActive (triviaPage);
		correct.SetActive (correctPage);
		wrong.SetActive (wrongPage);

		page1.SetActive (pageOne);
		page2.SetActive (pageTwo);

	}

	void check2DObjectClicked ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Mouse is pressed down");

			RaycastHit hitInfo = new RaycastHit ();
			if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo)) {
				//Debug.Log ("Object Hit is " + hitInfo.collider.gameObject.name);

				//If you want it to only detect some certain game object it hits, you can do that here
				if (hitInfo.collider.gameObject.name == triviaButton.name) {
					homePage = false;
					triviaPage = true;
					Debug.Log ("Trivia");

				} else if (hitInfo.collider.gameObject.name == select2.name) {
					correctPage = true;
					triviaPage = false;
					Debug.Log ("Correct");

				} else if (hitInfo.collider.gameObject.name == select1.name) {
					wrongPage = true;
					triviaPage = false;
					Debug.Log ("Wrong");

				} else if (hitInfo.collider.gameObject.name == "Ok") {
					wrongPage = false;
					correctPage = false;
					homePage = true;
					Debug.Log ("Back to home page");
				} else if (hitInfo.collider.gameObject.name == journal.name) {
					homePage = false;
					pageOne = true;
					Debug.Log ("Journal");

				} else if (hitInfo.collider.gameObject.name == backPage1.name) {
					pageOne = false;
					homePage = true;
					Debug.Log ("Back to homepage");

				} else if (hitInfo.collider.gameObject.name == backPage2.name) {
					pageTwo = false;
					pageOne = true;
					Debug.Log ("Back to page 1");

				} else if (hitInfo.collider.gameObject.name == nextPage1.name) {
					pageOne = false;
					pageTwo = true;
					Debug.Log ("Next");
				}
			} 
		} 
	}
}
