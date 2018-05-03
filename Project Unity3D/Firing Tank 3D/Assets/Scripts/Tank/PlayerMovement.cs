using UnityEngine;

public class PlayerMovement : TankMovement {
	private bool isTouch =false;

	// Cac bien nay duoc set trong Script CanvasControl de dieu khien
	[HideInInspector]
	public bool isLeft = false, isRight = false, isTop = false, isBottom = false;

	void FixedUpdate(){
		//keyboard test
		Move();
	    touchMove ();
	}
		
	private void touchMove(){
		if (isTop) {
			transform.LookAt (transform.position + Vector3.forward);
			isTouch = true;
		}
		if (isBottom) {
			transform.LookAt (transform.position + Vector3.back);
			isTouch = true;
		}
		if (isLeft) {
			transform.LookAt (transform.position + Vector3.left);
			isTouch = true;
		}
		if (isRight) {
			transform.LookAt (transform.position + Vector3.right);
			isTouch = true;
		}
		if (isTouch) {
			transform.Translate (Vector3.forward * m_Speed * Time.deltaTime);
			isTouch = false;
		}

	}

	private void Move() {
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.LookAt (transform.position + Vector3.forward);
			isTouch = true;
		}

		if(Input.GetKey(KeyCode.DownArrow)){
			transform.LookAt (transform.position + Vector3.back);
			isTouch = true;
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.LookAt (transform.position + Vector3.left);
			isTouch = true;
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			transform.LookAt (transform.position + Vector3.right);
			isTouch = true;
		}
		if (isTouch) {
			transform.Translate (Vector3.forward * m_Speed * Time.deltaTime);
			isTouch = false;
		}
	}

}