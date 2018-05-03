using UnityEngine;
using System.Collections;

public class CanvasControl : MonoBehaviour {

	private PlayerMovement mover;
	private TankShooting firer;

	void Start () {
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		mover = (PlayerMovement) player.GetComponent(typeof(PlayerMovement));
		firer = (TankShooting) player.GetComponent(typeof(TankShooting));
	}
	
	public void goRight() {
		if (!GamePause.isPause) 
			mover.isRight = true;
	}

	public void goUp() {
		if (!GamePause.isPause) 
			mover.isTop = true;
	}

	public void goBack() {
		if (!GamePause.isPause) 
			mover.isBottom = true;
	}
	public void goLeft() {
		if (!GamePause.isPause) 
			mover.isLeft = true;
	}
	public void notAction() {
		mover.isLeft = false;
		mover.isRight = false;
		mover.isBottom = false;
		mover.isTop = false;
	}
	public void tankFire() {
		if (!GamePause.isPause) 
			firer.Fire ();
	}
}
