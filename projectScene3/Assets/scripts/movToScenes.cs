using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movToScenes : MonoBehaviour {
	[SerializeField] private string nxtLvl;

     void OnTriggerEnter2D(Collider2D other)
    {
		if (other.CompareTag("Player"))
		{
			SceneManager.LoadScene(nxtLvl);
		}
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
