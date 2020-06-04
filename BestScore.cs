using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {

	private Text Bscore;
	public float Score;

	// Use this for initialization
	void Start () {
		Bscore = GameObject.Find("BestScore").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		Bscore.text = "Best Score: " + Score.ToString("N0");
	}
}
