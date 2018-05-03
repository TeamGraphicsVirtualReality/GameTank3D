using UnityEngine;
using UnityEngine.UI;

public class GamePause : MonoBehaviour {
	public static bool isPause = false ;

	private GameObject imageButtonPause;

	void Start(){
		imageButtonPause = GameObject.FindGameObjectWithTag ("ImageButtonPause");
	}

	public void setPause(){
		isPause = !isPause;
		if (isPause) {
			imageButtonPause.GetComponent<Image>().color = Color.red;
			Time.timeScale = 0;
		} else {
			imageButtonPause.GetComponent<Image>().color = Color.white;
			Time.timeScale = 1;
		}
	}
}
