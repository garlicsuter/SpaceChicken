using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour {
	public Sprite normalButton, activeButton;
	public GameObject laser;
	public GameObject chicken;
	public GameObject boss;
	private chickenScript Score;
	void Awake()
	{
		Score = chicken.GetComponent<chickenScript> (); 
	}

	void OnMouseDown()
	{
		this.GetComponent<SpriteRenderer>().sprite = activeButton;
		if (chicken.activeInHierarchy == true)
		{
			Instantiate (laser, chicken.transform.position, Quaternion.identity);
			//Instantiate (boss, chicken.transform.position, Quaternion.identity);
		}
		print (Score.score);
	}

	void OnMouseUp()
	{
		this.GetComponent<SpriteRenderer>().sprite = normalButton;
	}
}













