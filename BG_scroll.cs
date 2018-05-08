using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_scroll : MonoBehaviour {

	[Range(1f, 20f)]
	public float scrollSpeed = 1f;
	Vector2 startPos;
	public Renderer rend;
	private float bgHeight;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		startPos = transform.position;
		bgHeight = rend.bounds.size.y;
	}

	// Update is called once per frame
	void Update () {
		float newPos = Mathf.Repeat (Time.time * scrollSpeed, bgHeight);
		transform.position = startPos + Vector2.down * newPos;
	}
}
