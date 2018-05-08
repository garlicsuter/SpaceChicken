using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour {

	public AudioClip fire;
	public AudioClip collect;
	public AudioClip destroy;
	public AudioClip bgMusic;
	static AudioSource audioSrc;


	// Use this for initialization
	void Start () {
		audioSrc = GetComponent<AudioSource>();
		audioSrc.PlayOneShot (bgMusic);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			audioSrc.PlayOneShot (fire);
		}
			
	}
	public void PlaySound(string clip) {
		switch (clip) {
		case "fire":
			audioSrc.PlayOneShot (fire);
			break;
		case "collect":
			audioSrc.PlayOneShot (collect);
			break;
		case "destroy":
			audioSrc.PlayOneShot (destroy);
			break;
		case "bgMusic":
			audioSrc.PlayOneShot (bgMusic);
			break;
		
		}
	}
}
