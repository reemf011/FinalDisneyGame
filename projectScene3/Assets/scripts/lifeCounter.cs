using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeCounter : MonoBehaviour {
	public GameObject h1, h2, h3, GameOver;
	public static int health;
	// Use this for initialization
	void Start ()
	{
		health = 3;
		h1.gameObject.SetActive(true);
		h2.gameObject.SetActive(true);
		h3.gameObject.SetActive(true);
		GameOver.gameObject.SetActive(false);

		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (health > 3) ;
		health = 3;
		switch (health)
		{
			case 3:

				h1.gameObject.SetActive(true);
				h2.gameObject.SetActive(true);
				h3.gameObject.SetActive(true);
				break;
			case 2:
				h1.gameObject.SetActive(true);
				h2.gameObject.SetActive(true);
				h3.gameObject.SetActive(false);
				break;

			case 1:
				h1.gameObject.SetActive(true);
				h2.gameObject.SetActive(false);
				h3.gameObject.SetActive(false);
				break;

			case 0:
				h1.gameObject.SetActive(false);
				h2.gameObject.SetActive(false);
				h3.gameObject.SetActive(false);
				GameOver.gameObject.SetActive(true);
				Time.timeScale = 0;
				break;

		}



		
	}
}
