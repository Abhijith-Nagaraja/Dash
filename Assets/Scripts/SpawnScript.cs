using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public GameObject obstacle;
//	public GameObject powerup;
	
	float timeElapsed = 0;
	float spawnCycle = 1.5f;
	float y = 0f;
	float z = 30f;
	float[] x = {-2.5f,0.0F,2.5f};

	void Update () {
		if (GameControllerScript.isGameOver == false) {
			timeElapsed += Time.deltaTime;
			if (timeElapsed > spawnCycle) {
				int obstacles = Random.Range (0, 10000) % 3;

				int xindex = Random.Range (0, 1000) % 3;
				GameObject temp;
				temp = (GameObject)Instantiate (obstacle);
				temp.transform.position = new Vector3 (x [xindex], y, z);
				temp.transform.Rotate (0, 175, 0);

				if (obstacles > 0) {
					xindex = Random.Range (0, 1000) % 3;
					GameObject temp1;
					temp1 = (GameObject)Instantiate (obstacle);
					temp1.transform.position = new Vector3 (x [xindex], y, z);
					temp1.transform.Rotate (0, 175, 0);
				}

				if (obstacles > 1) {
					xindex = Random.Range (0, 1000) % 3;
					GameObject temp1;
					temp1 = (GameObject)Instantiate (obstacle);
					temp1.transform.position = new Vector3 (x [xindex], y, z);
					temp1.transform.Rotate (0, 175, 0);
				}

				timeElapsed -= spawnCycle;
			}
		}
	}
}