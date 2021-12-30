using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausenResume : MonoBehaviour {
	public GameObject PauseScreen;
	public static bool paused;
	public KeyCode PausedButton;
	// Use this for initialization
	void Start ()
	{

		paused = false;
		PauseScreen.SetActive(false);








	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(PausedButton) && !paused)
		{

			Paused();
		}

		else if (Input.GetKeyDown(PausedButton) && paused)
		{

			Resumed();
		}


	}


	public void Paused()
	{
		PauseScreen.SetActive(true);
		paused = true;
		Time.timeScale = 0;



	}
	public void Resumed()
	{
		PauseScreen.SetActive(false);
		paused = false;
		Time.timeScale=1 ;

	}
}
