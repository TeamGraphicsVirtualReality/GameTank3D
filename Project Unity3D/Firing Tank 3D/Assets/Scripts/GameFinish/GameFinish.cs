using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour {

	public void reStartAllGame(){
		PlayerPrefs.SetInt ("leveldata",1);
		SceneManager.LoadSceneAsync("GameStart");
	}
}
