using UnityEngine;
using System.Collections;

public class EndTitleScript : MonoBehaviour {
	
	public GUISkin myskin;
	
	Vector2 resolution;
	float y;
	private Rect rect;
	
	private void OnGUI()
	{	
		resolution=new Vector2(Screen.width, Screen.height);
		y=resolution.y/1920.0f; //change 1920 by your y value
		GUI.skin = myskin;
		GUI.Label(new Rect (Screen.width/2 - 200, 250 * y, 500, 200), "GAME OVER");
	}
}
