using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleanupScript : MonoBehaviour {
	
	public GameObject cleanup_sensor;


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


}
