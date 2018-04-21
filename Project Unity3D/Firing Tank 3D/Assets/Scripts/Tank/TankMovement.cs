using UnityEngine;

public class TankMovement : MonoBehaviour {
	public float m_Speed = 7f;
	public float m_PitchRange = 0.2f;

	protected Rigidbody mRigidbody;

	private void Awake() {
		mRigidbody = GetComponent < Rigidbody > ();
	}

	private void OnEnable() {
		if (mRigidbody != null)
			mRigidbody.isKinematic = false;
	}

	private void OnDisable() {
		if (mRigidbody != null)
			mRigidbody.isKinematic = true;
	}
}
