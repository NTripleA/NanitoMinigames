using UnityEngine;
using System.Collections;

public class ChangeCameraOnClick : MonoBehaviour {

	//[SerializeField]
	public GameObject Camera1; 
	//[SerializeField]
	public GameObject Camera2; 

	public static bool MainCamera = true;
	public static bool SecondCamera = false;


	// Use this for initialization
	void Start ()
    {
		Camera1.GetComponent<Camera> ().enabled = true;
		Camera2.GetComponent<Camera> ().enabled = false;
		Debug.Log ("start changeCameraOnClick script");
	}
	
	// Update is called once per frame
	void Update ()
    {
		Camera1.GetComponent<Camera> ().enabled = MainCamera;
		Camera2.GetComponent<Camera> ().enabled = SecondCamera;	
		Debug.Log ("update");

	}

	void OnMouseDown()
    {
		MainCamera = !MainCamera;
		SecondCamera = !SecondCamera;

		Debug.Log ("mouse down");


	}
}