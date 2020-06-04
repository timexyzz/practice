using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationColtroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			this.GetComponent<Animator> ().SetTrigger ("UptotheAir");
			transform.Rotate (new Vector3 (0.0f, 0.0f, 30.0f));
		}
		if (Input.GetMouseButtonUp (0)) {
			this.GetComponent<Animator> ().SetTrigger ("StopJump");
			transform.Rotate (new Vector3 (0.0f, 0.0f, -30.0f));
		}
	}
}
