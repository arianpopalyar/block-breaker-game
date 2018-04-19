using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {
	private LevelManager levelManager;
	private int timesHit;
	public AudioClip crack;
	public static int  breakableCount = 0;
	private bool isBreakable;

	public Sprite[] hitSprites;

	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		if(isBreakable){
			breakableCount++;
			print("breakable count = "+breakableCount);
		}

		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	//void OnTriggerEnter2D (Collider2D Col) {
	void OnCollisionEnter2D(Collision2D coll){
		AudioSource.PlayClipAtPoint (crack, transform.position);
		if (isBreakable){
			HandleHits();
		}
	}

	void HandleHits(){
		timesHit++;
		int maxHit;
		maxHit = hitSprites.Length +1;
		if(timesHit >= maxHit){
			breakableCount--;
			levelManager.BrickDestroyed();
			Destroy(gameObject);
		} else{
			LoadSprites();
		}
	}
	void LoadSprites(){
		int spriteIndex = timesHit - 1;
		if (hitSprites[spriteIndex]){
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}

	void SimulateWin(){
		levelManager.LoadNextLevel();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
