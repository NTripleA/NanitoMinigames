using UnityEngine;
using System.Collections;

public class FadeAway : MonoBehaviour {

	private Animator anim;
	private float timer;
	private float totalTime;
	public bool switchingImage;

	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator> ();
		anim.SetBool ("picChange", false);
		totalTime = 0.05f;
		timer = totalTime;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (switchingImage) {
			anim.SetBool ("picChange", true);
			timer -= Time.deltaTime;
			if (timer < 0) {
				switchingImage = false;
			}
		} else{
			anim.SetBool ("picChange", false);
			resetTimer ();
		}
	}

	private void resetTimer(){
		timer = totalTime;
	}
}
