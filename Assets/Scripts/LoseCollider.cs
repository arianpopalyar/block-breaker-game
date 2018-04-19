using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
	private LevelManager levelManager;

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D trigger) {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		print("Trigger");
		levelManager.LoadLevel("Lose Screen");
	}
// Update is called once per frame
//	void OnCollisionEnter2D (Collider2D collision) {
//		print("Collision");
//	}
}
