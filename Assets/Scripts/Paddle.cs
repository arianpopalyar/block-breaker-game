using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	public bool autoPlay = false;
	private Ball ball;
	public float minX, maxX;

	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}

	// Update is called once per frame
	void Update () {
		if(!autoPlay){
		MoveWithMouse();
		} else {
		AutoPlay();
		}
	}

	void AutoPlay(){
		Vector3	paddlePos = new Vector3 (1.51f, this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp((ballPos.x),minX, maxX);
		this.transform.position = paddlePos;
	}

	void MoveWithMouse(){
		Vector3	paddlePos = new Vector3 (1.51f, this.transform.position.y, 0f);
	//this will give mouse position in game unit;"mouse position in x axes/ with screen width * 16"
		float mousePosBlock = Input.mousePosition.x /Screen.width *16;
		paddlePos.x = Mathf.Clamp((mousePosBlock),minX, maxX);

		this.transform.position = paddlePos;
	}
}
