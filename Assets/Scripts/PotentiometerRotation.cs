using UnityEngine;
using System.Collections;

public class PotentiometerRotation : MonoBehaviour {

	public float rotationSpeed;
	public int maxImages;
	private int imageCounter;
	private float maxRotation;
	private float rotationCounter;
	private bool zoomIn;
	private bool isRotating;

	private SwapTexture textures;
	private FadeAway fade;
	public GameObject screen;

	// Use this for initialization
	void Start () {
	
		imageCounter = 0;
		rotationCounter = 0;
		maxRotation = 180;

		textures = FindObjectOfType<SwapTexture> ();
		fade = FindObjectOfType<FadeAway> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (!isRotating && imageCounter < maxImages && Input.GetKeyDown (KeyCode.UpArrow)) {
			isRotating = true;
			zoomIn = true;
			imageCounter++;

			fade.switchingImage = true;
			textures.currentTexture++;
			if (textures.currentTexture > textures.textures.Length - 1)
				textures.currentTexture = textures.textures.Length - 1;

			screen.GetComponent<Renderer> ().material.mainTexture = textures.textures [textures.currentTexture];

		} else if (!isRotating && imageCounter > 0 && Input.GetKeyDown (KeyCode.DownArrow)) {
			isRotating = true;
			zoomIn = false;
			imageCounter--;

			fade.switchingImage = true;
			textures.currentTexture--;
			if (textures.currentTexture < 0) 
				textures.currentTexture = 0;

			screen.GetComponent<Renderer> ().material.mainTexture = textures.textures [textures.currentTexture];
		}

		if (isRotating && zoomIn && rotationCounter < maxRotation) {
			ZoomIn ();
		} else if (isRotating && !zoomIn && (rotationCounter > 0 && rotationCounter <= 90)) {
			ZoomOut ();
		} else {
			isRotating = false;
			transform.rotation = Quaternion.Euler(0, 0, 0);
			rotationCounter = 90;
		}
		Debug.Log ("rotationCounter =" + rotationCounter +  "  imageCounter =" + imageCounter);
	}

	private void ZoomIn(){
		transform.Rotate (new Vector3 (0, 0, rotationSpeed), Space.Self);
		rotationCounter = transform.eulerAngles.z;
	}

	private void ZoomOut(){
		transform.Rotate (new Vector3 (0, 0, -rotationSpeed), Space.Self);
		rotationCounter = transform.eulerAngles.z;
	}
}
