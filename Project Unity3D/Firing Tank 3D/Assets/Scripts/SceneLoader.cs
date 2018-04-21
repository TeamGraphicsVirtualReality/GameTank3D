using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
	private bool is_load_gameplay = false;
	private bool load_scene = false;
	public Text textLoading;
	public static int currentLevel = 1;

	void Start(){
		currentLevel = PlayerPrefs.GetInt ("leveldata",1);
	}

	void Update () {
		if (is_load_gameplay && !load_scene) {
			load_scene = true;

			textLoading.text = "Loading...";

			SceneManager.LoadSceneAsync ("GameLevel" + currentLevel);
		}
	}

	public void loadGameScene () {
		is_load_gameplay = true;
	}
}
