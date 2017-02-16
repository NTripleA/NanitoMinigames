using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {

	public GameObject camera1;
	public static bool move_right = true;
	public static bool move_left = false;
	public static bool stay = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!stay) {
			if (move_right) {
				camera1.GetComponent<Camera>().transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
				stay = !stay;
			} 
			else if (move_left) {
				camera1.GetComponent<Camera>().transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y-90, 0));
				stay = !stay;
			}
		}
	
	}

	void OnMouseDown() {
		move_right = !move_right;
		move_left = !move_left;
		stay = !stay;
	}
}
