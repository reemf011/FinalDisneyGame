using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthBar : MonoBehaviour
{
	Image gainingHealth;
	float maxhealth = 100f;
	public static float health;

	// Use this for initialization
	void Start()
	{

		gainingHealth = GetComponent<Image>();
		health = maxhealth;
	}

	// Update is called once per frame
	void Update()
	{
		gainingHealth.fillAmount = health / maxhealth;

	}
}