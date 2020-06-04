using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirectorController : MonoBehaviour {

	public GameObject stonePrefab1;
	public GameObject stonePrefab2;
	public GameObject stonePrefab3;
	public float speed;
	private Text score;
	private Text Bscore;
	public float Btime;
	public float Ctime;
	public float time;
	private float term1;
	private float term2;
	private float term3;
	private float span = 30.0f;
	public GameObject player;
	public bool coli;
	//BestScore bs;
	//YourScore ys;
	GameObject eyes;

	// Use this for initialization
	void Start () {
		GameObject Cat = Instantiate (player) as GameObject;
		score = GameObject.Find("Score").GetComponent<Text>();
		Bscore = GameObject.Find("BestScore").GetComponent<Text>();
	//	bs = FindObjectOfType<BestScore> ();
	//	ys = FindObjectOfType<YourScore> ();
		eyes = GameObject.Find ("눈");
		term1 = span;
		term2 = span*2;
		term3 = span*3;
		speed = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		term1 += Time.deltaTime + speed*0.1f;
		term2 += Time.deltaTime + speed*0.1f;
		term3 += Time.deltaTime + speed*0.1f;
		speed += 0.001f;
		Bscore.text = "Best Score: " + PlayerPrefs.GetFloat("BestScore",0).ToString("N0");
		if (term1 > span*3) {
			term1 = 0;
			GameObject go1 = Instantiate (stonePrefab1) as GameObject;
			int py = Random.Range (-7, 7);
			go1.transform.position = new Vector3 (20, py, 0);
		}
		if (term2 > span*3) {
			term2 = 0;
			GameObject go2 = Instantiate (stonePrefab2) as GameObject;
			int py = Random.Range (-7, 7);
			go2.transform.position = new Vector3 (20, py, 0);
		}
		if (term3 > span*3) {
			term3 = 0;
			GameObject go3 = Instantiate (stonePrefab3) as GameObject;
			int py = Random.Range (-7, 7);
			go3.transform.position = new Vector3 (20, py, 0);
		}
		score.text = "Score: " + time.ToString("N0");
//		ys.Score = time;
		if (time > PlayerPrefs.GetFloat("BestScore",0)) {
			PlayerPrefs.SetFloat("BestScore", time);
		}

		eyes.GetComponent<Transform> ().localScale += new Vector3 (0, speed*0.001f, 0);
		if (eyes.GetComponent<Transform> ().localScale.y >= 3) {
			eyes.GetComponent<Transform> ().localScale = new Vector3 (1, 3, 0);
		}
	}

}
