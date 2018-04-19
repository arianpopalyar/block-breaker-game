using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;

	void Awake() {
	//	Debug.Log("Music player awake"+GetInstanceID());
		if (instance != null){
			Destroy (gameObject);
			print("music destroyed");
		}	else{
			instance = this ;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
