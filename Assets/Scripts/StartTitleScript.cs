using UnityEngine;
using System.Collections;

public class StartTitleScript : MonoBehaviour {

	public GUISkin myskin;
	
	Vector2 resolution;
	float y;
	private Rect rect;
	
	private void OnGUI()
	{	
		resolution=new Vector2(Screen.width, Screen.height);
		y=resolution.y/1920.0f; //change 1920 by your y value
		GUI.skin = myskin;
		rect = new Rect (Screen.width/2 - 150, 250 * y, 400, 200);
		GUI.Label(rect, "DASH!!!");
	}
}
