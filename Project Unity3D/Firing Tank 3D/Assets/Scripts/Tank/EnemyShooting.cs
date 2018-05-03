using UnityEngine;
using System.Collections;

public class EnemyShooting : TankShooting {
	private bool isActive = true;

	void Update() {
		if(isActive)
			StartCoroutine (WaitTime());
	}

	IEnumerator WaitTime(){
		isActive = false;
		yield return new WaitForSeconds (Random.Range (2f, 4f));
		isActive = true;
		Fire();
	}
}
