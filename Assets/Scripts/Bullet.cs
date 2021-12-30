using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float speed = 3f;
	void Start () {
	
	}
	
	void FixedUpdate () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}
}
