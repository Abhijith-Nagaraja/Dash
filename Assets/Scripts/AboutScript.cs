using UnityEngine;
using System.Collections;

public class AboutScript : MonoBehaviour {

	public string gameLevel;

	public GUISkin myskin;

	Vector2 resolution;
	float y;
	
	private void OnGUI()
	{	
		resolution=new Vector2(Screen.width, Screen.height);
		y=resolution.y/1920.0f; //change 1920 by your y value
		GUI.skin = myskin;

		GUI.Label(new Rect (Screen.width/2 - 150, 450 * y, 400, 200), "DEVELOPERS");
		GUI.Label(new Rect (Screen.width/2 - 160, 460 * y, 400, 200), "__________");
		GUI.Label(new Rect (Screen.width/2 - 200, 600 * y, 500, 200), "Abhijith Nagaraja");
		GUI.Label(new Rect (Screen.width/2 - 280, 725 * y, 600, 200), "Ramya Lakshminarayana");
		if (GUI.Button(new Rect (Screen.width/2 - 200, 1500 * y, 400, 150), "BACK"))
		{
			Application.LoadLevel(gameLevel);
		}
	}
}
