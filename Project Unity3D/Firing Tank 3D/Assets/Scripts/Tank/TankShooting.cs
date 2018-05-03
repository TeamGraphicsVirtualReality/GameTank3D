using UnityEngine;
using UnityEngine.UI;

public class TankShooting : MonoBehaviour {
	public Rigidbody m_Shell;
	// Prefab of the shell.
	public Transform m_FireTransform;
	
    //Giới hạn bắn của đạn
	public float m_RangeFire = 90f;

	public void Fire() {
		Rigidbody shellInstance =Instantiate(m_Shell, m_FireTransform.position, m_FireTransform.rotation)as Rigidbody;
 
        //vận tốc của đạn
        //đi theo hướng của điểm bắn
		shellInstance.velocity = m_RangeFire * m_FireTransform.forward;
	}
}
