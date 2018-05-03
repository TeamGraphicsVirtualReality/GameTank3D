using UnityEngine;
using System.Collections;
public class EnemyMovement : TankMovement {
	public float minTime,maxTime;
	private int maxSize = 4;
	private Vector3[] orientation = new Vector3[4];
	private Vector3 []lookAtByAxis= { Vector3.forward, Vector3.back, Vector3.left,Vector3.right};
	bool isActive = true;
	private string boundary = "Boundary";
	private int orientIndex;

	void reCalculate(){
		Vector3 temp = transform.position;
		for (int i = 0; i < maxSize; i++) {
			orientation [i] = temp + lookAtByAxis[i];
		}
	}

	void Start (){
		reCalculate ();
	}

	void Update(){
		reCalculate ();
	}

	void FixedUpdate(){
		if (isActive) {
			StartCoroutine (WaitTime ());
		}
		else enemyMovement ();
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == boundary) {
			orientIndex  = Random.Range (0, maxSize);
			enemyTurn ();
		}
	}

	void enemyTurn(){
		transform.LookAt (orientation[orientIndex]);
	}

	void enemyMovement(){
		transform.Translate (Vector3.forward * m_Speed * Time.deltaTime);
	}

	IEnumerator WaitTime(){
		isActive = false;
		yield return new WaitForSeconds (Random.Range (minTime, maxTime));
		isActive = true;
		orientIndex = Random.Range (0, maxSize);
		enemyTurn ();
	}
}
