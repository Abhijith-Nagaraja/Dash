using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour {
	public string gameLevel;
	
	public GUISkin myskin;
	
	Vector2 resolution;
	float y;
	private string highScore = "";
	
	private void OnGUI()
	{	
		resolution=new Vector2(Screen.width, Screen.height);
		y=resolution.y/1920.0f; //change 1920 by your y value
		GUI.skin = myskin;
		
		int currentScore = ((int)GameControllerScript.score);

		int oldHighscore = PlayerPrefs.GetInt("highscore", 0);    
		if(currentScore > oldHighscore)
		{
			highScore = "\n(New High Score)";
			PlayerPrefs.SetInt("highscore", currentScore);
			PlayerPrefs.Save();
		}

		Debug.Log (highScore);

		GUI.Label(new Rect (Screen.width/2 - 200, 500 * y, 400, 200), " Your Score: " + currentScore.ToString () + highScore);

		if (GUI.Button(new Rect (Screen.width/2 - 200, 800 * y, 400, 150), "Main Menu"))
		{
			Application.LoadLevel(gameLevel);
		}

		if (GUI.Button(new Rect (Screen.width/2 - 200, 1100 * y, 400, 150), "Exit"))
		{
			Application.Quit();
		}
	}
}
