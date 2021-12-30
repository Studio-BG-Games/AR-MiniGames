using UnityEngine;
using System.Collections;

public class UIActions : MonoBehaviour {

	public GameObject Cannon;

	public GameObject CannonBall;

	public float CannonBall_Forward_Force;

	public void Shoot () {
		Instantiate(CannonBall,Cannon.transform.position,Cannon.transform.rotation);
	}
}
