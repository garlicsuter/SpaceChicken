using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossScript : MonoBehaviour {

	public GameObject bomb;
	public float initialDelay;
	public float repeatDelay;

	void Start ()
	{
		InvokeRepeating("spawnBomb", initialDelay, repeatDelay);
	}

	void spawnBomb()
	{
		Instantiate(bomb, transform.position, Quaternion.identity);
	}
}
