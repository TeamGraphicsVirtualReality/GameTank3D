using UnityEngine;
using System.Collections;

public class WallBrown : MonoBehaviour {
	
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Shell"){
			if (this.gameObject.tag != "Enemy") {
				Destroy (this.gameObject);
				if(this.gameObject.tag == "Player")
					//GameObject.FindGameObjectWithTag ("GameController").SendMessage ("gameOver");
					GameManager.gameOver();
			}
		}
		if (other.gameObject.tag == "ShellPlayer") {
			if (this.gameObject.tag == "Enemy") {
				GameObject.FindGameObjectWithTag ("GameController").SendMessage ("destroyEnemy");
				GameObject.FindGameObjectWithTag ("GameController").SendMessage ("addEnemy");
			}
			Destroy (this.gameObject);
		}

	}
}
