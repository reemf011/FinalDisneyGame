using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text ScoreText;
	private int ScoreVal;
	// Use this for initialization
	void Start () {
		ScoreVal = 0;
		ScoreText.text = "Score: " + ScoreVal;
		
	}

	private void OnTriggerEnter2D(Collider2D objectt)
	{
		if (objectt.CompareTag("obj1"))
		{
			ScoreVal += 1;
			Destroy(objectt.gameObject);
			ScoreText.text = "Score: " + ScoreVal;

		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
