using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chickenScript : MonoBehaviour {
	public GameObject boss;
	public GameObject gameover;
	public Text scoreText;
	public int score;
	private bool noboss = true;
	public soundmanager arrow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Enemy")
		{
			arrow.PlaySound("destroy");
			Debug.Log ("Heyyyy");
			gameover.transform.position = new Vector3 (0, 0, 0);
			this.gameObject.SetActive(false);
		}

		if (coll.gameObject.tag == "Pickup")
		{
			arrow.PlaySound("collect");
			Debug.Log ("You got a coin!");
			coll.gameObject.SetActive (false);
			score = score + 1;
			scoreText.text = score.ToString();
			if (score >= 3 && noboss == true)
			{
				boss.SetActive (true);
				noboss = false;
			}
		}

	}



}
