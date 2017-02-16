using UnityEngine;
using System.Collections;

public class MouseDrag : MonoBehaviour {

    private Vector3 startPoint;
    

	// Use this for initialization
	void Start ()
    {
        startPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDrag()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
    }

    void OnMouseUp()
    {
            transform.position = startPoint;
         
    }
}
