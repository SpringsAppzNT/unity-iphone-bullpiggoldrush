using UnityEngine;
using System.Collections;

public class DestroyWhenOutOfBounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void Die(){
		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		if (pos.y < -7.5) {
			Die();
		}
			
	}
}
