/YourScore/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourScore : MonoBehaviour {

	private Text Yscore;
	public float Score;

	// Use this for initialization
	void Start () {
		Yscore = GameObject.Find("YourScore").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		Yscore.text = "Your Score: " + Score.ToString("N0");
	}
}
/YourScore/


/TitleEvent/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleEvent : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	
	void Update () {
		if (Input.GetMouseButton (0)) {
			SceneManager.LoadScene ("Game");
		}
	}
}
/TitleEvent/

