using UnityEngine;
using System;
using System.Collections;

public class GameControllerScript : MonoBehaviour {
	public GUISkin skin;
	public static float score=0f;      //total score
	public static bool isGameOver = false;
	float totalTimeElapsed = 0;
	public string gameLevel;
	private bool waitFl = false;

	void Start()
	{
		score=0f;
		isGameOver = false;
	}
	// Update is called once per frame
	void Update () {
		if(isGameOver)     //check if isGameOver is true
		{
			return; 
		}
		totalTimeElapsed += Time.deltaTime; 
		score = totalTimeElapsed*10;  //calculate the score based on total time elapsed
	}

	void OnGUI()
	{
		GUI.skin=skin;
		//check if game is not over, if so, display the score and the time left
		if(!isGameOver)    
		{
			GUI.Label(new Rect(Screen.width-270, 10, 250, Screen.height/6), "SCORE: "+((int)score).ToString());
		}
		//if game over, display game over menu with score
		else
		{
			GUI.Label(new Rect(Screen.width/2 - 200, Screen.height/2-200, 400, 100), "You Crashed!!!!!!!!!!");
			StartCoroutine(wait());
		}
	}

	IEnumerator wait()
	{
		yield return new WaitForSeconds(3);
		Application.LoadLevel(gameLevel);
	}


}
