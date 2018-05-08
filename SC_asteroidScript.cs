using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidScript : MonoBehaviour {
	
	public GameObject cleanup_sensor;
	public GameObject boom;

	// Use this for initialization
	void Start () {
		cleanup_sensor = GameObject.FindGameObjectWithTag ("cleanup");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < cleanup_sensor.transform.position.y) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "laser")
		{
			Instantiate (boom, this.transform.position, Quaternion.identity);
			this.gameObject.SetActive (false);
		}
	}
}
