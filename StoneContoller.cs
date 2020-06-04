using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneContoller : MonoBehaviour {
	float spd;
	GameDirectorController dir;
	public GameObject cat;

	// Use this for initialization
	void Start () {
		dir = FindObjectOfType<GameDirectorController> ();
		spd = dir.speed;
		dir.coli = false;
		this.cat = GameObject.Find ("Cat(Clone)");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-0.1f*spd, 0, 0);

		if (transform.position.x < -20.0f) {
			Destroy (gameObject);
		}
		if (dir.coli == true) {
			this.cat.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezePositionY;
			this.cat.transform.Translate (-0.15f, 0, 0);
			if (this.cat.transform.position.y > 6.8f) {
				this.cat.transform.Translate (-1.0f, 0, 0);
				Time.timeScale = 0.0f;
				if (this.cat.transform.position.y > 15.0f) {
					this.cat.transform.position = new Vector3 (-30.0f, 0, 0);
				}
			}
		}
	}
	void OnCollisionEnter2D(Collision2D other) {
		dir.coli = true;
		// Debug.Log (coli);
	}
}
