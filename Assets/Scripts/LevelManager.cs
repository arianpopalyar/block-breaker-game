using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
	Debug.Log("Level load requested for: "+name);
	Bricks.breakableCount =0;
	Application.LoadLevel(name);
	//SceneManager.LoadScene(name);

	}

	public void QuitRequest (){
	Debug.Log("Quit request ");
	Application.Quit();
	}

	public void LoadNextLevel(){
		Bricks.breakableCount =0;
		Application.LoadLevel(Application.loadedLevel + 1);
		//SceneManager.LoadScene(SceneManager.sceneLoaded + 1);
	}

	public void BrickDestroyed(){
		if(Bricks.breakableCount <=0){
			LoadNextLevel();
		}
	}
}