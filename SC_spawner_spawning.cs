using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_spawning : MonoBehaviour {
	public GameObject savesInstance;
	public GameObject asteroidInstance;
	public float initialDelay;
	public float repeatDelay;
	public float asteroid_initialDelay;
	public float asteroid_repeatDelay;

	// Use this for initialization
	void Start () {
		InvokeRepeating("spawnSave", initialDelay, repeatDelay);
		InvokeRepeating("spawnAsteroid", asteroid_initialDelay,asteroid_repeatDelay );

	}
	
	void spawnSave()
	{
		Instantiate(savesInstance, transform.position, Quaternion.identity);
	}

	void spawnAsteroid()
	{
		Instantiate(asteroidInstance, transform.position, Quaternion.identity);
	}
}
