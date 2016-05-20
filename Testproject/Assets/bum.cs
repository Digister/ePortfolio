using UnityEngine;
using System.Collections;

public class bum : MonoBehaviour {

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown ("space")) {
			rb.AddForce(new Vector3(0,10,0), ForceMode.Impulse);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.AddForce (0, 0, 5);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			rb.AddForce (0, 0, -5);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddForce (-5, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddForce (5, 0, 0);
		}
	}
}
