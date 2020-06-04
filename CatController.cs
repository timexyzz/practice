using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatController : MonoBehaviour {
	float jumpP = 9.8f;
	private float MaxSpeed = 5.0f;
	private float MinSpeed = -10.0f;
	private Rigidbody2D rb;
	public Vector3 playerV;
	private Vector3 coli;
	GameDirectorController gd;
	public GameObject cat;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		transform.position = new Vector3(-10.0f, -1.0f, 0.0f);
		coli = new Vector3 (0.0f, 10.0f, 0.0f);
		gd = FindObjectOfType<GameDirectorController> ();
		this.cat = GameObject.Find ("Cat(Clone)");
		Time.timeScale = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		playerV = GetComponent<Transform>().position;
		if (Input.GetMouseButton (0)) {
			rb.AddForce (transform.up * jumpP * 9.8f * rb.mass);
		}
		if (playerV.y <= -6.5f) {
			rb.AddForce (coli, ForceMode2D.Impulse);
		}
		if (playerV.y >= 6.75f) {
			rb.AddForce (coli*-1.0f, ForceMode2D.Impulse);
		}
		if (playerV.x < -20.0f) {
			Time.timeScale = 0.0f;
			gd.Ctime = gd.time;
			if (gd.Btime > gd.Ctime) {
				gd.Btime = gd.Ctime;
			}
			if (Input.GetMouseButtonDown (0)) {
				//Destroy (gameObject);
				gd.coli = false;
				this.cat.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None;
				SceneManager.LoadScene ("Title");
			}
		}

		if (rb.velocity.y >= MaxSpeed) {
			rb.velocity = new Vector2(0, MaxSpeed);
		}
		if (rb.velocity.y <= MinSpeed) {
			rb.velocity = new Vector2(0, MinSpeed);
		}
	}
}
