using UnityEngine;

public class EagleHealth : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Shell" || other.gameObject.tag == "ShellPlayer") {
			GameObject.FindGameObjectWithTag ("GameController").SendMessage ("gameOver");
			Destroy (this.gameObject); 
		}
	}
}
