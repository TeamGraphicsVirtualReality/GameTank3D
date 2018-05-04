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
        // hàm delay ,tank máy sẽ bắn từ khoảng thời gian 0.5s đến 1.5s
		yield return new WaitForSeconds (Random.Range (0.5f, 1.5f));
		isActive = true;

        // bắn của tankshooting
		Fire();
	}
}
