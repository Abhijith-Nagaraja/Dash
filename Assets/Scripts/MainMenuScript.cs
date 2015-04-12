using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour 
{
	public string gameLevel;
	public string creditLevel;
	public GUISkin myskin;
	
	private void OnGUI()
	{
		Vector2 resolution=new Vector2(Screen.width, Screen.height);
		float y=resolution.y/1920.0f; //change 1920 by your y value
		GUI.skin = myskin;

		GUI.Label(new Rect (Screen.width/2 - 160, 500 * y, 400, 100), "High Score: " + PlayerPrefs.GetInt("highscore", 0) );

		GUI.Label(new Rect (Screen.width/2 - 110, 700 * y, 400, 100), "Main Menu");
		
		if (GUI.Button(new Rect (Screen.width/2 - 200, 900 * y, 400, 150), "Play")){
			Application.LoadLevel(gameLevel);
		}

		if (GUI.Button(new Rect (Screen.width/2 - 200, 1200 * y, 400, 150), "About")){
			Application.LoadLevel(creditLevel);
		}
				
		if (GUI.Button(new Rect (Screen.width/2 - 200, 1500 * y, 400, 150), "Exit")){
			Application.Quit();
		}
	}
}