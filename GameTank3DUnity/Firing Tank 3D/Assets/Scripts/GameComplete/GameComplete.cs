using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameComplete : MonoBehaviour {
	
	public Text score;
	private int yourScore ;

	void Start(){

		yourScore = PlayerPrefs.GetInt ("currentScore",0);
		score.text = "" + yourScore;
	}

	public void loadLevel () {
		++SceneLoader.currentLevel;
		PlayerPrefs.SetInt ("leveldata",SceneLoader.currentLevel);
		SceneManager.LoadSceneAsync(GameManager.level+ SceneLoader.currentLevel);
	}

}
