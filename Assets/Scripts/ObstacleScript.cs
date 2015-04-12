using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {
	public float objectSpeed = .5f;
	
	void Update () {
		objectSpeed += objectSpeed * .01f;
		transform.Translate(0.04f, 0, objectSpeed);
	}
}