using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {


	const int maxLevel = 5;
    //số lượng max tank máy là 10
	const int numberOfEnemy = 10;

	const int minNumberOfEnemy = 4;
	public static string level = "GameLevel";

	public GameObject []enemy;//mảng các tank máy

	private GameObject showCurrentLevel;//text level hiện tại
	private GameObject score;//text diem
	private static int maxEnemy;
	private static int countScore = 0;

	void Start () {
		score = GameObject.FindGameObjectWithTag ("Score");
		showCurrentLevel = GameObject.FindGameObjectWithTag ("Level");

		//maxEnemy = numberOfenemy;// + 10 * (SceneLoader.currentLevel - 1);
		maxEnemy = numberOfEnemy + 10 * (SceneLoader.currentLevel - 1);
			
		showCurrentLevel.GetComponent<Text> ().text = ""+ SceneLoader.currentLevel; 
		GameObject []respawn = GameObject.FindGameObjectsWithTag ("Respawn");
		for (int i = 0; i < respawn.Length; i++) {
			Instantiate (enemy[Random.Range(0, 2)], respawn [i].transform.position, Quaternion.identity);
		}
	}

	void OnGUI() {
		score.GetComponent<Text>().text = "" + maxEnemy;
	}

	void Update(){
		if (maxEnemy <= 0){
			if (SceneLoader.currentLevel >= maxLevel) {
				gameFinish ();
			} else {
				gameConplete ();
			}
		}
	}

	public void addEnemy(){
		if (maxEnemy >= minNumberOfEnemy) {
			GameObject[] respawn = GameObject.FindGameObjectsWithTag ("Respawn");
			int index = Random.Range (0, respawn.Length);
			Instantiate (enemy [Random.Range (0, 2)], respawn [index].transform.position, Quaternion.identity);
		}
	}

	public void destroyEnemy(){
		maxEnemy--;
		countScore++;
		PlayerPrefs.SetInt("currentScore",countScore);
	}

	public static void gameOver(){

		if(maxEnemy == numberOfEnemy + 10 *(SceneLoader.currentLevel -1))
			PlayerPrefs.SetInt("currentScore",0);
		
		maxEnemy = numberOfEnemy + 10 *(SceneLoader.currentLevel -1);
		SceneManager.LoadSceneAsync("GameOver");
	}

	public void gameConplete(){
		SceneManager.LoadSceneAsync("GameComplete");
	}

	private void gameFinish(){
		SceneManager.LoadSceneAsync("GameFinish");
	}
}
