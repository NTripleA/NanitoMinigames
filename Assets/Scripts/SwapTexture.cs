using UnityEngine;
using System.Collections;

public class SwapTexture : MonoBehaviour {

	public Texture[] textures;
	public int currentTexture;

	// Use this for initialization
	void Start () {
		currentTexture = 0;
		GetComponent<Renderer> ().material.mainTexture = textures [currentTexture];
	}
	
	// Update is called once per frame
	void Update () {

	}
}
