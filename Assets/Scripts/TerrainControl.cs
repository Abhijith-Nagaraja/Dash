using UnityEngine;
using System.Collections;

public class TerrainControl : MonoBehaviour {
	float speed = .5f;
	int counter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//float offset = Time.time * speed;  
		if (GameControllerScript.isGameOver == false) {

			if (counter < 200) {
				transform.Translate (new Vector3 (0, 0, -speed));
				counter = counter + 1;
			} else {
				transform.Translate (new Vector3 (0, 0, 100));
				counter = 0;
			}
		}
	}
}
