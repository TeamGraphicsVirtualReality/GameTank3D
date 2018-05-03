using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {
	//public Text highScore;
	public Text yourScore;
	//int highscore = 0;
	int yourscore = 0;

	void Start () {

		//highscore = PlayerPrefs.GetInt ("HighScore",0);
		yourscore = PlayerPrefs.GetInt ("currentScore",0);

		//highScore.text = "" + highscore;
		yourScore.text = "" + yourscore;
	}
	
	public void playAgain(){
		SceneManager.LoadSceneAsync(GameManager.level + SceneLoader.currentLevel);
	}

}
