using UnityEngine;

namespace Complete {
	public class ShellExplosion : MonoBehaviour {
		public ParticleSystem m_ExplosionParticles; // Reference to the particles that will play on explosion.

		public float m_MaxLifeTime = 2f; // The time in seconds before the shell is removed.

		private void Start() {
			// If it isn't destroyed by then, destroy the shell after it's lifetime.
			Destroy(gameObject, m_MaxLifeTime);
		}

		private void OnTriggerEnter(Collider other) {
			
			// Unparent the particles from the shell.
			m_ExplosionParticles.transform.parent = null;

			// Play the particle system.
			m_ExplosionParticles.Play();

			// Once the particles have finished, destroy the gameobject they are on.
			Destroy(m_ExplosionParticles.gameObject, m_ExplosionParticles.duration);

			// Destroy the shell.
			Destroy(gameObject);
		}
	}
}
