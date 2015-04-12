using UnityEngine;
using System.Collections;

public class GroundControl : MonoBehaviour {
	//Material texture offset rate
	float speed = .5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControllerScript.isGameOver == false) {
		float offset = Time.time * speed;                             
		renderer.material.mainTextureOffset = new Vector2(0, -offset); 
	}
	}
}
