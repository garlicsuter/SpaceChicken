using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoveScript : MonoBehaviour {
	// Thanks to Alexander Zotov's YouTube video for the original script this one is based on!
	// Find him here: https://www.youtube.com/channel/UCYgUFrFyfr5IyL8HfTTiWhA


	// Background scroll speed can be set in Inspector with slider
	[Range(1f, 20f)]
	public float scrollSpeed = 1f;

	// Scroll offset value to smoothly repeat backgrounds movement
	public float scrollOffset;

	Collider2D m_Collider;
	Vector3 m_Size;

	// Start position of background movement
	Vector2 startPos;

	// Backgrounds new position
	float newPos;

	// Use this for initialization
	void Start () {
		// Getting backgrounds start position
		startPos = transform.position;
		 
		//finds the height off your background to set the scrollOffset amount
		//Fetch the Collider from the GameObject
		m_Collider = GetComponent<Collider2D>();

		//Fetch the size of the Collider volume
		m_Size = m_Collider.bounds.size;

		//Output to the console the size of the Collider volume
		Debug.Log("Collider2D Size : " + m_Size);
	}
	
	// Update is called once per frame
	void Update () {
		// Calculating new backgrounds position repeating it depending on scrollOffset
		newPos = Mathf.Repeat (Time.time * - scrollSpeed, scrollOffset);

		// Setting new position
		transform.position = startPos + Vector2.up * newPos;
	}
}
